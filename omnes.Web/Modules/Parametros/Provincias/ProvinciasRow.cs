using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Provincias")]
[DisplayName("Provincias"), InstanceName("Provincias")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class ProvinciasRow : Row<ProvinciasRow.RowFields>, IIdRow, INameRow
{
    const string jIdPais = nameof(jIdPais);

    class RowTemplate
    {
        [DisplayName("Id Provincia"), Identity, IdProperty]
        public int? IdProvincia { get; set; }

        [DisplayName("Nombre Provincia"), Size(200), NotNull, QuickSearch, NameProperty]
        public string NombreProvincia { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Pais"), NotNull, ForeignKey("Paises", "IdPais"), LeftJoin(jIdPais), TextualField(nameof(IdPaisNombrePais))]
        public int? IdPais { get; set; }

        [DisplayName("Id Pais Nombre Pais"), Expression($"{jIdPais}.[NombrePais]")]
        public string IdPaisNombrePais { get; set; }
    }
}