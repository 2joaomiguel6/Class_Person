using System;
namespace ams_heranca_treeclass_pessoa{
    class Persons{
        public string CPF { get; set; }
        public string Name { get; set; }

        public Persons(string cpf, string name){
            CPF = cpf;
            Name = name;
        }
    }
}