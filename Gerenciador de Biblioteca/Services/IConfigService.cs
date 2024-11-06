﻿namespace Gerenciador_de_Biblioteca.Services
{
    public interface IConfigService
    {
        int GetValue();
    }

    public class ConfigService : IConfigService
    {
        private int _value;
        public int GetValue()
        {
            _value++;
            return _value;
        }
    }
}
