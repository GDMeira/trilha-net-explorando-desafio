using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2.Models
{
    public class Pessoa
    {
        public Pessoa(string name, string lastName) 
        {
            this.Name = name;
            this.LastName = lastName;
        }
        private string _name = "";
        public string Name { 
            get => _name; 

            set {
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser vazio.");
                } else {
                    _name = value;
                }
            }
            }

        private string _lastName = "";
        public string LastName { 
            get => _lastName; 
            set {
                if (value == "") {
                    throw new ArgumentException("O sobrenome não pode ser vazio.");
                } else {
                    _lastName = value;
                }
            }
            }

        
    }
}