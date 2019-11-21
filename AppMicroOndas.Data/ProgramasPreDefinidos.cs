using AppMicroOndas.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Data
{
    public static class ProgramasPreDefinidos
    {
        public static List<ProgramaAquecimentoModel> ProgramaLista = new List<ProgramaAquecimentoModel>() {
            new ProgramaAquecimentoModel(){
                 Nome               = "Frango",
                 Instrucao          = "Assar frango inteiro rápido",
                 PotenciaTxt        = "7",
                 AlimentoCompativel = new string[]{ "frango", "ave", "aves" },
                 TempoTxt           = "60",
                 Caracter           = "f"
            },
            new ProgramaAquecimentoModel(){
                 Nome               = "Carne",
                 Instrucao          =  "Assar carne 1kg",
                 PotenciaTxt        = "8",
                 AlimentoCompativel = new string[]{ "boi", "costela", "alcatra", "carne" },
                 TempoTxt           = "120",
                 Caracter           = "c"
            },
            new ProgramaAquecimentoModel(){
                 Nome               = "Pipoca",
                 Instrucao          = "Estourar pipoca padrão",
                 PotenciaTxt        = "3",
                 AlimentoCompativel = new string[]{ "pipoca", "milho" },
                 TempoTxt           = "5",
                 Caracter           = "i"
            },
            new ProgramaAquecimentoModel(){
                 Nome               = "Peixe",
                 Instrucao          = "Assar peixe",
                 PotenciaTxt        = "6",
                 AlimentoCompativel = new string[]{ "peixe", "tilapia" },
                 TempoTxt           = "30",
                 Caracter           = "p"
            },
            new ProgramaAquecimentoModel(){
                 Nome               = "Lasanha",
                 Instrucao          = "Cozinhar lasanha de microondas padrão",
                 PotenciaTxt        = "5",
                 AlimentoCompativel = new string[]{ "lasanha" },
                 TempoTxt           = "40",
                 Caracter           = "l"
            }
        };
    }
}
