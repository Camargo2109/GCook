namespace GCook.Helpers;

public static class TranslateIdentityErros
{
    public static string TranslateErrorsMessage(string codeError)
    {
        string message = codeError switch
        {
            "DefaultError" => "Ocorreu um erro desconhecido",
            "ConcurrencyFailure" => "Falha de concorrência otimista, o objeto foi modificado.",
            "InvalidToken" => "Token invalido.",
            "LoginAlreadyAssociated" => "Já existe um usuário com este login.",
            "InvalidUserName" => $"Este login é inválido, um login deve cnter apenas letras ou dígitos.",
            "InvalidEmail" => "E-mail inválido.",
            "DuplicateUserName" => "Este login já está sendo utilizado",
            "DuplicateEmail" => $"Este email já está sendo utilizado",
            "InvalidRoleName" => "Esta permissão ja esta sendo Utilizada"
            
        };
    }
}

