import { TwoFactorAuthType } from "./TwoFactorAuthType";
import { PrefixedContext } from "@serenity-is/corelib";

export interface UserForm {
}

export class UserForm extends PrefixedContext {
    static formKey = 'Administration.User';
}

[TwoFactorAuthType]; // referenced types