import { proxyTexts } from "@serenity-is/corelib/q";

namespace omnes.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleKey: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleName: string;
                export const RolePermissionId: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const ImpersonationToken: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const MobilePhoneNumber: string;
                export const MobilePhoneVerified: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const TwoFactorAuth: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Parametros {

            namespace AreasTrabajo {
                export const Baja: string;
                export const Descripcion: string;
                export const IdAreaTrabajo: string;
                export const IdEmpresa: string;
                export const IdEmpresaRazonSocial: string;
                export const IdTennant: string;
                export const IdTennantDescripcion: string;
            }

            namespace CodigosPostales {
                export const Baja: string;
                export const CodPostal: string;
                export const IdCodPostal: string;
                export const IdLocalidad: string;
                export const IdLocalidadNombreLocalidad: string;
                export const IdPais: string;
                export const IdPaisNombrePais: string;
                export const IdProvincia: string;
                export const IdProvinciaNombreProvincia: string;
            }

            namespace Empresas {
                export const Altura: string;
                export const Baja: string;
                export const Calle: string;
                export const Cuit: string;
                export const DireccionUrl: string;
                export const DocumentosRelacionados: string;
                export const Dpto: string;
                export const IdCodPost: string;
                export const IdCodPostCodPostal: string;
                export const IdEmpresa: string;
                export const IdLocalidad: string;
                export const IdPais: string;
                export const IdPaisNombrePais: string;
                export const IdProvincia: string;
                export const IdProvinciaNombreProvincia: string;
                export const IdTennant: string;
                export const IdTennantDescripcion: string;
                export const InicioActividades: string;
                export const Latitud: string;
                export const Logo: string;
                export const Longitud: string;
                export const Mail: string;
                export const NombreContacto: string;
                export const NombreFantasia: string;
                export const Observaciones: string;
                export const OtraReferencia: string;
                export const Piso: string;
                export const RazonSocial: string;
                export const Telefono: string;
            }

            namespace EstadosCiviles {
                export const Baja: string;
                export const DescripcionEstadoCivil: string;
                export const IdEstadoCivil: string;
            }

            namespace Etiquetas {
                export const Baja: string;
                export const Descripcion: string;
                export const IdEtiqueta: string;
                export const IdTennant: string;
                export const IdTennantDescripcion: string;
                export const Observaciones: string;
            }

            namespace Localidades {
                export const Baja: string;
                export const IdLocalidad: string;
                export const IdPais: string;
                export const IdPaisNombrePais: string;
                export const IdProvincia: string;
                export const IdProvinciaNombreProvincia: string;
                export const NombreLocalidad: string;
            }

            namespace Paises {
                export const Baja: string;
                export const IdPais: string;
                export const NombrePais: string;
            }

            namespace Provincias {
                export const Baja: string;
                export const IdPais: string;
                export const IdPaisNombrePais: string;
                export const IdProvincia: string;
                export const NombreProvincia: string;
            }

            namespace Tennants {
                export const Baja: string;
                export const Descripcion: string;
                export const IdTennant: string;
                export const Observaciones: string;
            }

            namespace TiposCuentasBancaria {
                export const Baja: string;
                export const Descripcion: string;
                export const IdTipoCuentaBancaria: string;
                export const Observaciones: string;
            }

            namespace TiposDocumento {
                export const Baja: string;
                export const IdTipoDocumento: string;
                export const NombreTipoDocumento: string;
                export const Sigla: string;
            }

            namespace TiposDomicilio {
                export const IdTipoDomicilio: string;
                export const NombreTipoDomicilio: string;
            }

            namespace TiposEmail {
                export const IdTipoEmail: string;
                export const NombreTipoEmail: string;
            }

            namespace TiposTelefono {
                export const IdTipoTelefono: string;
                export const NombreTipoTelefono: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const SuccessMessage: string;
            }

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    omnes['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleKey:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RoleName:1,RolePermissionId:1},User:{DisplayName:1,Email:1,ImpersonationToken:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,MobilePhoneNumber:1,MobilePhoneVerified:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,TwoFactorAuth:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Parametros:{AreasTrabajo:{Baja:1,Descripcion:1,IdAreaTrabajo:1,IdEmpresa:1,IdEmpresaRazonSocial:1,IdTennant:1,IdTennantDescripcion:1},CodigosPostales:{Baja:1,CodPostal:1,IdCodPostal:1,IdLocalidad:1,IdLocalidadNombreLocalidad:1,IdPais:1,IdPaisNombrePais:1,IdProvincia:1,IdProvinciaNombreProvincia:1},Empresas:{Altura:1,Baja:1,Calle:1,Cuit:1,DireccionUrl:1,DocumentosRelacionados:1,Dpto:1,IdCodPost:1,IdCodPostCodPostal:1,IdEmpresa:1,IdLocalidad:1,IdPais:1,IdPaisNombrePais:1,IdProvincia:1,IdProvinciaNombreProvincia:1,IdTennant:1,IdTennantDescripcion:1,InicioActividades:1,Latitud:1,Logo:1,Longitud:1,Mail:1,NombreContacto:1,NombreFantasia:1,Observaciones:1,OtraReferencia:1,Piso:1,RazonSocial:1,Telefono:1},EstadosCiviles:{Baja:1,DescripcionEstadoCivil:1,IdEstadoCivil:1},Etiquetas:{Baja:1,Descripcion:1,IdEtiqueta:1,IdTennant:1,IdTennantDescripcion:1,Observaciones:1},Localidades:{Baja:1,IdLocalidad:1,IdPais:1,IdPaisNombrePais:1,IdProvincia:1,IdProvinciaNombreProvincia:1,NombreLocalidad:1},Paises:{Baja:1,IdPais:1,NombrePais:1},Provincias:{Baja:1,IdPais:1,IdPaisNombrePais:1,IdProvincia:1,NombreProvincia:1},Tennants:{Baja:1,Descripcion:1,IdTennant:1,Observaciones:1},TiposCuentasBancaria:{Baja:1,Descripcion:1,IdTipoCuentaBancaria:1,Observaciones:1},TiposDocumento:{Baja:1,IdTipoDocumento:1,NombreTipoDocumento:1,Sigla:1},TiposDomicilio:{IdTipoDomicilio:1,NombreTipoDomicilio:1},TiposEmail:{IdTipoEmail:1,NombreTipoEmail:1},TiposTelefono:{IdTipoTelefono:1,NombreTipoTelefono:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{FormInfo:1,FormTitle:1,SubmitButton:1,SuccessMessage:1},Login:{ForgotPassword:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{ActivateEmailSubject:1,ActivationCompleteMessage:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}},SiteTitle:1},Navigation:{Dashboard:1,LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},Layout:{Language:1,Theme:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,PasswordConfirmMismatch:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = omnes.Texts;