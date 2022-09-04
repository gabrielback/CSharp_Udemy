# Seção 006 (Comportamento de memória, arrays e listas)

    Esse capítulo é focado no entendimento do comportamento da memoria, arrays e listas.
    O capítulo contém alguns exercícios para fixação do conteúdo que estarão anexados abaixo.

 * [076 - Listas](./076_Listas/Program.cs)
    ```
    Listas São instanciadas e depois preenchidas. Ao contrário de um array onde você define o tamanho em sua criação.
    ```

    * Criando Nova Lista
        ```csharp
              List<string> list = new List<string>();
        ```
    * Métodos

      * Add
        ```csharp
        //Adiciona um item na ultima posição da lista
        list.Add("Gabriel");
        ```
      * Insert
        ```csharp
        //Adiciona um item na posição especificada
        list.Insert(0, "Antes do primeiro elemento")
        ```

      * Count 
        ```csharp
        //Retorna o tamanho da lista
        list.Count;
        ```

      * .Find
        ```csharp
        //Retorna o primeiro nome que contenha a letra "a"
        listName.Find(x => x.Contains("a"));
        
        //Retorna o último nome que contenha a letra "a".
        listName.FindLast(x => x.Contains("a"));

        //Coloca todos os nomes que tenham menos de 15 caracteres em outra lista.
        List<string> secondListName = listName.FindAll(x => x.Length < 15);
        ```

      * Remove
        ```csharp
        //Remove o primeiro nome que contenha a letra "a".
        listName.Remove(x => x.Contains("a"));

        //Remove todos qua contenham o sobrenome Pereira.
        lista.RemoveAll(x => x.Contains("Pereira"));
        ```

* [0** - *](./076_Listas/Program.cs)

[Voltar](../README.md)