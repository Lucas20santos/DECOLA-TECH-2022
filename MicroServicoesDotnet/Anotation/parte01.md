# MicroSserviços

## Por que Microsserviços

- Os microsserviços tem o objetivo de facilitar e agilisar
- Micro serviços encapsulam estado e comportamente
- Micro serviços  possuem  deploy independentes
- Micro serviços devem ter tratamentos isolados à falhas

## Monolitos

### Vantagens

- Rápido e fácil iniciar
- Infraestrutura simples
- Debug fascinante

### Desvantagens

- Problema com merge-conflicts
- Conexões simultâneo TCP é limitada
- Deadlock e concorrẽncia
- Bugs e defeitos colaterais(Único ponto de falha)
- Build/ Deploy longos pesados
- Baixa escalabilidade
- Agregação de tecnologia
- Demora de aculturamento

#### O que podemos fazer para melhora ?

## Escalabilidade

### Escalabilidade Vertical

- coloca mais memoria
- coloca mais cpu
- com o tempo isso vai ficar mais caro

### Escalabilidade horizontal

- Load Balancer: vai distribuir os acessos para os vários servidores
- dividi a escalabilidade em vários monoliticos

### Escalabilidade horizontal com microsserviços

- Martin Fallow pensador sobre microsserviços
- API Manenger - Load Banlancer

## Conceito de DevOps

- Desenvolver, entregar rápidos
- operar em cima




## Ecossistema de Microsserviços

- para cada microsserviço eu tenho  um banco de dados

## O que é uma API Pública e como se interagem

- Micro serviços dependem apenas um do outro via APIs públicas
- Micro serviços podem (e devem) ser poliglotas em seus stack


