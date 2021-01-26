using System;
using System.Collections.Generic;

using CursoCSharp.ProjetosTeste;
using CursoCSharp.Fundamentos;  // Chamado para class (pasta) Fundamentos.
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {   // Main é a porta de entrada C#. Só pode haver 1.
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Projetos
                {"Calculadora - Projetos", Calculadora.Executar},
                {"Jogo da Forca - Projetos", JogoDaForca.Executar},

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentario - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveiisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadore Relacinais - Fundamentos", OperadoreRelacinais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperdorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If  Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If Elseiif - Estruturas de Controle", EstruturaIfElseiif.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach- Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break- Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue- Estruturas de Controle", UsandoContinue.Executar},

                // Classes e Metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}