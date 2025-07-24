# Exercícios Práticos: Variáveis de Texto (char e string) em C#

## 📚 Conteúdo da Aula

Nesta aula, aprendemos que:

- O tipo `char` armazena **apenas um caractere**
- O tipo `string` armazena **palavras, frases ou textos inteiros**
- Strings possuem métodos úteis como:
  - `Trim()` — remove espaços do início e fim
  - `StartsWith()` — verifica se começa com determinado texto
  - `EndsWith()` — verifica se termina com determinado texto
  - `Replace()` — substitui partes do texto
  - `Equals()` — compara se duas strings são iguais
- Cada caractere de uma `string` pode ser acessado por índice, começando do zero

---

## 🧠 Exercício 1: Declarando `char` e `string`

**Objetivo:** Compreender a diferença entre `char` e `string`.


- Declare uma variável do tipo char com valor 'A'
- Declare uma variável do tipo string com o valor "Aprender C# é divertido!"

- Mostre os dois valores no console com uma mensagem explicativa.
## 🧠 Exercício 2: Manipulando Texto com Trim e Replace
Objetivo: Utilizar os métodos Trim() e Replace().

csharp
Copiar
Editar
- Dada a string:
string mensagem = "  Bem-vindo ao mundo C#!  ";

- Remova os espaços em branco do início e fim da string
- Substitua "C#" por "da programação"

- Exiba a mensagem final no console.
## 🧠 Exercício 3: Verificando Início e Fim de Texto
Objetivo: Usar os métodos StartsWith() e EndsWith().

csharp
Copiar
Editar
- Dada a string:
string arquivo = "relatorio_final_2025.pdf";

- Verifique:
- - Se o nome do arquivo começa com "relatorio"
- - Se o nome termina com ".pdf"

- Exiba mensagens no console com os resultados das verificações.
## 🧠 Exercício 4: Acessando Caracteres por Índice
Objetivo: Navegar por uma string utilizando índices.

csharp
Copiar
Editar
- Dada a string:
string palavra = "programador";

- Mostre o primeiro, o último e o quinto caractere da string usando índices
- (Dica: use palavra[0], palavra[palavra.Length - 1], etc.)
## 🧠 Exercício 5: Comparando Strings
Objetivo: Usar o método Equals() para comparar textos.

csharp
Copiar
Editar
- Declare duas strings:
string senhaDigitada = "Csharp123";
string senhaCorreta = "CSharp123";

- Compare as duas usando o método Equals()
- Dica: use o parâmetro opcional para ignorar diferenças entre maiúsculas e minúsculas

- Mostre "Acesso concedido" se forem iguais, ou "Senha incorreta" se forem diferentes