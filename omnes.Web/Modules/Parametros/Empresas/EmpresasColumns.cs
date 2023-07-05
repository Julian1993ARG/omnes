using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace omnes.Parametros.Columns;

[ColumnsScript("Parametros.Empresas")]
[BasedOnRow(typeof(EmpresasRow), CheckNames = true)]
public class EmpresasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdEmpresa { get; set; }
    public string IdTennantDescripcion { get; set; }
    [EditLink]
    public string RazonSocial { get; set; }
    public string Cuit { get; set; }
    public DateTime InicioActividades { get; set; }
    public string DireccionUrl { get; set; }
    public string NombreFantasia { get; set; }
    public string Mail { get; set; }
    public string NombreContacto { get; set; }
    public string Telefono { get; set; }
    public string Calle { get; set; }
    public string Altura { get; set; }
    public string Piso { get; set; }
    public string Dpto { get; set; }
    public string Latitud { get; set; }
    public string Longitud { get; set; }
    public string OtraReferencia { get; set; }
    public int IdLocalidad { get; set; }
    public string IdCodPostCodPostal { get; set; }
    public string IdProvinciaNombreProvincia { get; set; }
    public string IdPaisNombrePais { get; set; }
    public string Logo { get; set; }
    public string DocumentosRelacionados { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
}