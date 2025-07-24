# Exercícios Práticos: Valores Booleanos em C#

## 📚 Conteúdo da Aula

Nesta aula, aprendemos que:

- O tipo `bool` representa valores lógicos: `true` ou `false`
- Booleans são usados para verificar condições como:
  - Se um usuário está logado
  - Se ele é administrador
  - Se um dispositivo está conectado
- São fundamentais em estruturas condicionais como `if`, `else`, `while`, etc.

---

## Exercício 1: Declarando Booleans

**Objetivo:** Praticar a criação de variáveis booleanas.


 Crie as seguintes variáveis:
 - usuarioLogado com valor verdadeiro
 - isAdmin com valor falso
 - dispositivoConectado com valor verdadeiro

 Exiba cada valor no console com uma mensagem explicativa.
## Exercício 2: Verificando Permissão
Objetivo: Usar booleanos em uma estrutura condicional.

csharp
Copiar
Editar
 Dado um usuário com as seguintes variáveis:
bool usuarioLogado = true;
bool isAdmin = false;

 Escreva uma estrutura condicional que:
 - Mostre "Acesso concedido ao painel de controle" se o usuário estiver logado E for admin
 - Caso contrário, mostre "Acesso negado"
## Exercício 3: Invertendo Valores
Objetivo: Usar o operador ! (negação lógica).

csharp
Copiar
Editar
 Suponha que você tem:
bool dispositivoConectado = false;

 Crie uma variável chamada dispositivoDesconectado que representa o valor oposto.
 Mostre os dois valores no console.
## Exercício 4: Condições Compostas
Objetivo: Trabalhar com expressões booleanas mais complexas.

csharp
Copiar
Editar
 Dado:
bool usuarioLogado = true;
bool isAdmin = true;
bool possuiAssinaturaAtiva = false;

 Escreva uma condição que exiba:
 - "Acesso Premium liberado" se o usuário estiver logado E (for admin OU tiver assinatura ativa)
 - Caso contrário, exiba "Acesso Premium bloqueado"
## Exercício 5: Simulação de Login
Objetivo: Criar uma simulação básica de autenticação usando booleanos.

csharp
Copiar
Editar
 Crie duas variáveis:
 - bool usuarioExiste = true;
 - bool senhaCorreta = false;

 Use uma estrutura condicional para:
 - Exibir "Login bem-sucedido" se ambas forem verdadeiras
 - Exibir "Usuário ou senha incorretos" se qualquer uma for falsa
Dica bônus: Experimente alterar os valores booleanos e veja como isso afeta a execução do programa!

yaml
Copiar
Editar
