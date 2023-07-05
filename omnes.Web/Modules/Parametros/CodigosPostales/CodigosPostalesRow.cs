using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("CodigosPostales")]
[DisplayName("Codigos Postales"), InstanceName("Codigos Postales")]
[ReadPermission("SuperAdmin")]
[ModifyPermission("SuperAdmin")]
public sealed partial class CodigosPostalesRow : Row<CodigosPostalesRow.RowFields>, IIdRow, INameRow
{
    const string jIdLocalidad = nameof(jIdLocalidad);
    const string jIdProvincia = nameof(jIdProvincia);
    const string jIdPais = nameof(jIdPais);

    class RowTemplate
    {
        [DisplayName("Id Cod Postal"), Identity, IdProperty]
        public int? IdCodPostal { get; set; }

        [DisplayName("Cod Postal"), Size(200), NotNull, QuickSearch, NameProperty]
        public string CodPostal { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Localidad"), NotNull, ForeignKey("Localidades", "IdLocalidad"), LeftJoin(jIdLocalidad), TextualField(nameof(IdLocalidadNombreLocalidad))]
        public int? IdLocalidad { get; set; }

        [DisplayName("Id Provincia"), NotNull, ForeignKey("Provincias", "IdProvincia"), LeftJoin(jIdProvincia), TextualField(nameof(IdProvinciaNombreProvincia))]
        public int? IdProvincia { get; set; }

        [DisplayName("Id Pais"), NotNull, ForeignKey("Paises", "IdPais"), LeftJoin(jIdPais), TextualField(nameof(IdPaisNombrePais))]
        public int? IdPais { get; set; }

        [DisplayName("Id Localidad Nombre Localidad"), Expression($"{jIdLocalidad}.[NombreLocalidad]")]
        public string IdLocalidadNombreLocalidad { get; set; }

        [DisplayName("Id Provincia Nombre Provincia"), Expression($"{jIdProvincia}.[NombreProvincia]")]
        public string IdProvinciaNombreProvincia { get; set; }

        [DisplayName("Id Pais Nombre Pais"), Expression($"{jIdPais}.[NombrePais]")]
        public string IdPaisNombrePais { get; set; }
    }
}