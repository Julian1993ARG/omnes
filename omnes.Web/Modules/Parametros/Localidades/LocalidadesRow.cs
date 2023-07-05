using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Localidades")]
[DisplayName("Localidades"), InstanceName("Localidades")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class LocalidadesRow : Row<LocalidadesRow.RowFields>, IIdRow, INameRow
{
    const string jIdProvincia = nameof(jIdProvincia);
    const string jIdPais = nameof(jIdPais);

    class RowTemplate
    {
        [DisplayName("Id Localidad"), Identity, IdProperty]
        public int? IdLocalidad { get; set; }

        [DisplayName("Nombre Localidad"), Size(200), NotNull, QuickSearch, NameProperty]
        public string NombreLocalidad { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Provincia"), NotNull, ForeignKey("Provincias", "IdProvincia"), LeftJoin(jIdProvincia), TextualField(nameof(IdProvinciaNombreProvincia))]
        public int? IdProvincia { get; set; }

        [DisplayName("Id Pais"), NotNull, ForeignKey("Paises", "IdPais"), LeftJoin(jIdPais), TextualField(nameof(IdPaisNombrePais))]
        public int? IdPais { get; set; }

        [DisplayName("Id Provincia Nombre Provincia"), Expression($"{jIdProvincia}.[NombreProvincia]")]
        public string IdProvinciaNombreProvincia { get; set; }

        [DisplayName("Id Pais Nombre Pais"), Expression($"{jIdPais}.[NombrePais]")]
        public string IdPaisNombrePais { get; set; }
    }
}