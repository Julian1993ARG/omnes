using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace omnes.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("AreasTrabajo")]
[DisplayName("Areas Trabajo"), InstanceName("Areas Trabajo")]
[ReadPermission("RRHH")]
[ModifyPermission("RRHH")]
public sealed partial class AreasTrabajoRow : Row<AreasTrabajoRow.RowFields>, IIdRow, INameRow
{
    const string jIdTennant = nameof(jIdTennant);
    const string jIdEmpresa = nameof(jIdEmpresa);

    class RowTemplate
    {
        [DisplayName("Id Area Trabajo"), Identity, IdProperty]
        public int? IdAreaTrabajo { get; set; }

        [DisplayName("Id Tennant"), NotNull, ForeignKey("Tennants", "IdTennant"), LeftJoin(jIdTennant), TextualField(nameof(IdTennantDescripcion))]
        public int? IdTennant { get; set; }

        [DisplayName("Id Empresa"), ForeignKey("Empresas", "IdEmpresa"), LeftJoin(jIdEmpresa), TextualField(nameof(IdEmpresaRazonSocial))]
        public int? IdEmpresa { get; set; }

        [DisplayName("Descripcion"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Tennant Descripcion"), Expression($"{jIdTennant}.[Descripcion]")]
        public string IdTennantDescripcion { get; set; }

        [DisplayName("Id Empresa Razon Social"), Expression($"{jIdEmpresa}.[RazonSocial]")]
        public string IdEmpresaRazonSocial { get; set; }
    }
}