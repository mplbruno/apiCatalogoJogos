using System;

namespace apiCatalogoJogos.InputModel
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;
        private int minimumLenght;
        private string errorMessage;

        public StringLenghtAttribute(int v, int MinimumLenght, string ErrorMessage)
        {
            this.v = v;
            minimumLenght = MinimumLenght;
            errorMessage = ErrorMessage;
        }
    }
}