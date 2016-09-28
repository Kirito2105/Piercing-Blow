namespace PiercingBlow.Commons.Model.Enum.Login
{
    public enum LoginState : uint
    {
        LOGGED_IN_OK = 0,
        ID_IS_ALREADY_LOGGED_IN = 0x80000101,
        ACCOUNT_IS_STILL_LOGGING_OUT = 0x80000104,
        FAILED_TO_LOGIN = 0x80000106,
        LONG_TIME_IS_INACTIVE = 0x80000107,
        ID_OR_PASSWORD_INCORRECT = 0x80000117,
        PASSWORD_MISMATCH = 0x80000118,
        DELETED_ACCOUNT = 0x80000119,
        UNCONFIRMED_EMAIL = 0x80000120,
        RESTRICTED_REGION = 0x80000123,
    }
}
