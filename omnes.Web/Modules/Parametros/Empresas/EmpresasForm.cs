using Serenity.ComponentModel;
using System;

namespace omnes.Parametros.Forms;

[FormScript("Parametros.Empresas")]
[BasedOnRow(typeof(EmpresasRow), CheckNames = true)]
public class EmpresasForm
{
    public int IdTennant { get; set; }
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
    public int IdCodPost { get; set; }
    public int IdProvincia { get; set; }
    public int IdPais { get; set; }
    public string Logo { get; set; }
    public string DocumentosRelacionados { get; set; }
    public bool Baja { get; set; }
    public string Observaciones { get; set; }
}