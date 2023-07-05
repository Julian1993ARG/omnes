using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Empresas")]
[DisplayName("Empresas"), InstanceName("Empresas")]
[ReadPermission("RRHH")]
[ModifyPermission("RRHH")]
public sealed partial class EmpresasRow : Row<EmpresasRow.RowFields>, IIdRow, INameRow
{
    const string jIdTennant = nameof(jIdTennant);
    const string jIdCodPost = nameof(jIdCodPost);
    const string jIdProvincia = nameof(jIdProvincia);
    const string jIdPais = nameof(jIdPais);

    class RowTemplate
    {
        [DisplayName("Id Empresa"), Identity, IdProperty]
        public int? IdEmpresa { get; set; }

        [DisplayName("Id Tennant"), NotNull, ForeignKey("Tennants", "IdTennant"), LeftJoin(jIdTennant), TextualField(nameof(IdTennantDescripcion))]
        public int? IdTennant { get; set; }

        [DisplayName("Razon Social"), Size(150), NotNull, QuickSearch, NameProperty]
        public string RazonSocial { get; set; }

        [DisplayName("Cuit"), Size(15), NotNull]
        public string Cuit { get; set; }

        [DisplayName("Inicio Actividades")]
        public DateTime? InicioActividades { get; set; }

        [DisplayName("Direccion Url")]
        public string DireccionUrl { get; set; }

        [DisplayName("Nombre Fantasia")]
        public string NombreFantasia { get; set; }

        [DisplayName("Mail"), Size(255), NotNull]
        public string Mail { get; set; }

        [DisplayName("Nombre Contacto"), Size(50)]
        public string NombreContacto { get; set; }

        [DisplayName("Telefono"), Size(50)]
        public string Telefono { get; set; }

        [DisplayName("Calle"), Size(200)]
        public string Calle { get; set; }

        [DisplayName("Altura"), Size(50)]
        public string Altura { get; set; }

        [DisplayName("Piso"), Size(50)]
        public string Piso { get; set; }

        [DisplayName("Dpto"), Size(50)]
        public string Dpto { get; set; }

        [DisplayName("Latitud"), Size(200)]
        public string Latitud { get; set; }

        [DisplayName("Longitud"), Size(200)]
        public string Longitud { get; set; }

        [DisplayName("Otra Referencia")]
        public string OtraReferencia { get; set; }

        [DisplayName("Id Localidad"), NotNull]
        public int? IdLocalidad { get; set; }

        [DisplayName("Id Cod Post"), ForeignKey("CodigosPostales", "IdCodPostal"), LeftJoin(jIdCodPost), TextualField(nameof(IdCodPostCodPostal))]
        public int? IdCodPost { get; set; }

        [DisplayName("Id Provincia"), NotNull, ForeignKey("Provincias", "IdProvincia"), LeftJoin(jIdProvincia), TextualField(nameof(IdProvinciaNombreProvincia))]
        public int? IdProvincia { get; set; }

        [DisplayName("Id Pais"), NotNull, ForeignKey("Paises", "IdPais"), LeftJoin(jIdPais), TextualField(nameof(IdPaisNombrePais))]
        public int? IdPais { get; set; }

        [DisplayName("Logo")]
        public string Logo { get; set; }

        [DisplayName("Documentos Relacionados")]
        public string DocumentosRelacionados { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Observaciones"), NotNull]
        public string Observaciones { get; set; }

        [DisplayName("Id Tennant Descripcion"), Expression($"{jIdTennant}.[Descripcion]")]
        public string IdTennantDescripcion { get; set; }

        [DisplayName("Id Cod Post Cod Postal"), Expression($"{jIdCodPost}.[CodPostal]")]
        public string IdCodPostCodPostal { get; set; }

        [DisplayName("Id Provincia Nombre Provincia"), Expression($"{jIdProvincia}.[NombreProvincia]")]
        public string IdProvinciaNombreProvincia { get; set; }

        [DisplayName("Id Pais Nombre Pais"), Expression($"{jIdPais}.[NombrePais]")]
        public string IdPaisNombrePais { get; set; }
    }
}