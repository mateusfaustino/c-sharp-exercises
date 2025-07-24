# Exercícios Práticos: Trabalhando com Datas e Horas em C#

## 📚 Conteúdo da Aula

Nesta aula, aprendemos a:

- Criar datas com `new DateTime(ano, mês, dia)`
- Obter a data/hora atual com `DateTime.Now` ou `DateTime.Today`
- Adicionar ou subtrair dias, meses, anos, horas, minutos e segundos
- Personalizar a exibição da data usando `ToString("formato")`

---

## 🧠 Exercício 1: Criando Datas Específicas

**Objetivo:** Criar datas com base em parâmetros.


- Crie uma data com o valor 12 de março de 2025
- Mostre essa data no console no formato padrão
- Exiba também a data no formato: "dd/MM/yyyy"
## 🧠 Exercício 2: Data e Hora Atual
Objetivo: Obter a data e a hora do sistema.

csharp
Copiar
Editar
- Obtenha a data e hora atual com DateTime.Now
- Obtenha apenas a data com DateTime.Today

- Exiba ambas no console nos seguintes formatos:
- - "Data completa: dd/MM/yyyy HH:mm:ss"
- - "Somente a data: dd/MM/yyyy"
## 🧠 Exercício 3: Adicionando e Subtraindo Tempo
Objetivo: Manipular datas com métodos como AddDays, AddMonths, AddHours, etc.

csharp
Copiar
Editar
- Crie uma data de início: 1º de janeiro de 2024
- Calcule e exiba:
- - A data 30 dias depois
- - A data 3 meses antes
- - A data 2 horas depois
## 🧠 Exercício 4: Comparando Datas
Objetivo: Comparar duas datas.

csharp
Copiar
Editar
- Crie duas datas:
- - data1 = 10/10/2024
- - data2 = 05/10/2024

- Compare qual é a mais recente
- Mostre no console: "data1 é mais recente" ou "data2 é mais recente"
## 🧠 Exercício 5: Formatando Datas
Objetivo: Exibir datas com formatos personalizados.

csharp
Copiar
Editar
- Obtenha a data e hora atual com DateTime.Now

- Exiba os seguintes formatos:
- - "Hoje é: segunda-feira, 24 de julho de 2025"
- - "Formato curto: 24/07/2025"
- - "Formato com hora: 24/07/2025 14:35"

- (Dica: use ToString com "dddd, dd 'de' MMMM 'de' yyyy" e outros formatos)