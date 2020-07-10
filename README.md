# Projeto Entra21

### Escrevendo e lendo o console
    // Escrever
    Console.WriteLine("Qual é a sua idade");

    // Ler e salvar o resultado
    var result = Console.ReadLine();

### Declarando variáveis e constantes
    var text = "meu texto"
    string text = "meu texto"
    const string test = "meu texto"

### Tipos básicos

    // Tipo numérico/int
    var = number = 1

    // Tipo texto/string
    var text = "meu texto"

    // Tipo booleano/ool
    var boolean = true

    // Tipo numérico com ponto flutuante/double
    var price = 4.099

    // Tipo Data/DateTime
    var currentDate = DateTime.Now

### Parsers / Transformadores
    // Transformar um texto em um número/int
    var userAge = int32.Parse(result);

### Operadores de comparação
#### (Toda comparação retorna um booleano/bool)
    // É igual? 
    1 == 1;
    // vai retornar true

    // É diferente?
    1 != 1;
    // vai retornar false

    // É diferente?
    !(1 == 1);
    // vai retornar false

### Operadores de comparação ara números/matemática
    // É maior? 
    1 > 1;
    // vai retornar false

    // É menor?
    1 < 1;
    // vai retornar false

    // É maior OU igual?
    1 >= 1;
    // vai retornar true

    // É menor OU igual?
    1 <= 1;
    // vai retornar true

    // Booleano da esquerda é true e o da direita também?
    true && true && false;
    // vai retornar false

    // Booleano da esquerda ou o da direita é true?
    false || false || true;
    // vai retornar true

### Operadores de matemática
    // Somar
    1 + 1;
    
    // Subtrair
    1 - 1;
    
    // Dividir
    2 / 1;

    // Multiplicar
    1 * 1;
   
    // Resto
    3 % 2;
    // vai retornar 1

### Blocos condicionais
    // Escrevendo olá SOMENTE quando 1 > 0
    if (1 > 0)
    {
       Console.WriteLine("Olá")
    }
    // Caso 1 NÃO for maior que 0, e 2 > 1, escreva boa tarde
    else if (2 > 1)
    {
       Console.WriteLine("boa tarde")
    }
    // Caso NENHUMA das condições anteriores forem verdadeiras, escreva 
    tchau
    {
       Console.WriteLine("tchau")
    }
    
### Comandos do editor
Selecionando o texto:
Segurar a tecla Shift e utilizar as setas.

Comando para comentar:
**CTRL + K + C**

Comando para descomentar
**CTRL + K + U**

Comando para desfazer
**CTRL + Z**

Comando para refazer
**CTRL + Y**

### Depurando a aplicação

1. Clicar na baratinha e depois no botão de engrenagem
2. Selecionar o texto '.NET Core'
3. Alterar opção "console" para "integratedTerminal"
4. Adicionar quantos breakpoint quiser (clicar na esquerda do número da linha)
5. Clicar na baratinha e no botão start (verde)
6. Selecionar o Terminal (Sair na tab "debug console")
7. **F10** vai para a próxima linha
8. **F5** para o próximo breakpoint
9. **Shift + F5** para o próximo breakpoint
10. **CTRL + Shift + F5** para reiniciar o debug
