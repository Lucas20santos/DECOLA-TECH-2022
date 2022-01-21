
# Características das classes
## Classe abstrata

Uma classe abstrata tem como objetivo ser exclusivamente um
modelo para ser herdado, portanto não pode ser instanciada.

Você pode implementar métodos ou deixa-los a cargo de quem
herdar.


## Classe Seleada 

Uma classe selada tem como objetivo de impedir que outras classes
façam uma herança dela, ou seja, nenhuma classe pode ser sua
derivada

Também existem métodos e propriedades seladas.

## Classe Object

A classe System.Object é a mãe de todas as classes na hierarquia 
do .NET

Toadas as classes derivam, direta ou indiretamente da classe
Object, e ela tem como objetivo prover serviços de baixo nível
para suas classes filhas.

- Equals(Object)
- - Esquals(Object, Object)
- Finalizer()

e muito mais