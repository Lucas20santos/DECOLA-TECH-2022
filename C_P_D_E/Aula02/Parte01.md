# Construtores

Um construtor 'eum método especial, que contém o mesmo nome
do seu tipo classe, e tem o objetivo de definir valores
padrão, limitar uma instância e facilitar a instanciação de um
objeto.

- Um construtor não possui um retorno
- Um construtor padrão é sempre definido quando não declaramos nenhum para sua classe.
- Uma classe pode ter mais de um construtor

## Construtor Padrão

- É um construtor que não tem parametros.
- Caso vc não declare um construtor a própria liguagem criar um 
construtor padrão sem parâmetro.

## Construtor Privado

- É um construtor que não pode ser usado para instânciar
- Quando é tentado instânciar um construtor privado C# retorna um erro

## Chamando o construtor da herança

Se uma classe é herdada por uma classe filha qualquer e essa 
classe pai tem um construtor e nesse construtor tem parâmetros; a
classe filha tem que respeitar esse comportamento do construtor
da classe pai.

- O contrutor da classe pai é chamada primeiro e logo após é chamado o construtor da classe filha.