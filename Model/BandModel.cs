using System;

namespace ScreenSound.Model{

    internal class BandModel{ // Band Model

        public string? Nome {get;set;}
        private string DataCriado {get;}
        private string HorarioCriado {get;}
        public string Criacao => $"Banda cadastrada no dia {this.DataCriado} às {this.HorarioCriado}";

        public BandModel(string? NomeBanda){
            this.Nome = NomeBanda;
            this.DataCriado = DateTime.Now.ToString("dd/MM/yyyy");
            this.HorarioCriado = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public override string ToString()
        {
            return $"{this.Nome} adicionada no dia {this.DataCriado}";
        }

    }
}