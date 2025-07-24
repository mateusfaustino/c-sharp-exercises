# Exercícios Práticos: Operações com Strings em C#

## 📚 Conteúdo da Aula

Nesta aula, aprendemos sobre:

- **Concatenação de strings** com `+`
- Adição de **espaços** e **caracteres especiais** (`\n`, `\t`, `\\`)
- **Interpolação de strings** com `$"Texto {variável}"`
- Uso de `StringBuilder` para concatenar muitas strings com performance
- Inserção de **parâmetros em strings fixas** com `string.Format()` (útil para traduções)

---

## 🧠 Exercício 1: Concatenando Frases

**Objetivo:** Praticar concatenação com `+` e adicionar espaços corretamente.

- Crie duas variáveis:
- string frase1 = "Aprender C# é divertido.";
- string frase2 = "Vamos praticar bastante!";

- Crie uma terceira string chamada paragrafo unindo as duas frases com um espaço entre elas.
- Exiba o resultado no console.
## 🧠 Exercício 2: Usando Caracteres Especiais
Objetivo: Inserir quebras de linha, tabulação e barras invertidas.

csharp
Copiar
Editar
- Crie uma string chamada textoFormatado com o seguinte conteúdo usando caracteres especiais:
- "Nome:\tJoão\nCaminho:\\Documentos\\Projetos\\CSharp"

- Exiba o texto no console exatamente com esse formato visual.
## 🧠 Exercício 3: Interpolação de Strings
Objetivo: Tornar o código mais legível usando string interpolation.

csharp
Copiar
Editar
- Crie duas variáveis:
- string linguagem = "C#";
- int aulas = 10;

- Use interpolação para gerar a frase:
- "Você está estudando C# e já completou 10 aulas."

- Exiba a frase no console.
## 🧠 Exercício 4: Usando StringBuilder
Objetivo: Criar um parágrafo com várias partes utilizando StringBuilder.

csharp
Copiar
Editar
- Use StringBuilder para criar o seguinte texto:
- "Olá, estudante!\nHoje vamos aprender sobre strings.\nPratique bastante para se tornar um mestre."

- Exiba o resultado no console ao final.
## 🧠 Exercício 5: Usando string.Format com Parâmetros
Objetivo: Inserir valores em uma string fixa usando string.Format().

csharp
Copiar
Editar
- Crie uma string base:
- string modelo = "Olá {0}, você concluiu {1}% do curso de {2}.";

- Use string.Format para substituir os valores por:
- nome = "Maria", progresso = 75, curso = "C#"

- Exiba o texto final no console.
