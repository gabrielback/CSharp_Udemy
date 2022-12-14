# Seção 004 (Classes, atributos, métodos, membros estáticos)

    Esse capitulo é focado no entendimento de Classes, atributos, métodos e membros estáticos.
    O capítulo contém alguns exercícios para fixação do conteúdo.
* [039 - Criando uma classe com três atributos para representar melhor um triângulo](./039_ClasseTriangulo_C_OOP/)

  * [040.1 - Primeiros exercícios](./040_Exercicios/040_Exerc%C3%ADcio01/)

  * [040.2 - Primeiros exercícios](./040_Exercicios/040_Exercicio02/)

* [041 - Adicionando Método para obtermos os benefícios de reaproveitamento de código](./041_ClasseTriangulo_C_OOP_Add_Metodo//)

* [042 - Começando a resolver um segundo problema exemplo](./042_PrecoDoProduto/)

* [043 - Object e ToString](./043_PrecoDoProduto_Object_ToString/)
  ```csharp
          public override string ToString()
        {
            return $"Nome: {Nome}," +
                $" Preço: ${Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" Quantidade: {Quantidade}," +
                $" Total em estoque: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
  ```

* [044 - Terminando de construir o programa](./043_PrecoDoProduto_Object_ToString/)

* [045 - Exercícios Propostos](./043_PrecoDoProduto_Object_ToString/)

  * [045.1 - Classe Retângulo](./045_1_ClasseRetangulo/Retangulo.cs) - [Program.cs](./045_1_ClasseRetangulo/Program.cs)

  * [045.2 - Classe Funcionário](./045_2_Funcionario/Funcionario.cs) - [Program.cs](./045_2_Funcionario/Program.cs)



  * [045.3 - Classe Aluno](./045_3_Aluno/Aluno.cs) - [Program.cs](./045_1_ClasseRetangulo/Program.cs)

 * [046 - Membros Estáticos](./readme.md)

    ```C#
    //Membros estáticos não precisam ser instanciados. Ex: 
    Math.sqrt()
    ```

[Voltar](../README.md)