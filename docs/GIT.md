# Comandos GIT

## Git clone
- Clonando um novo projeto.
``sh
 git clone git@github.com:escolaparaprogramadores/CarSystem.git
``
## Git add .
- Adicionando/removendo arquivos na stage.
``sh
 git add .
``
## Git commit
- Commitando as mudanças.
``sh
 git commit -am"Meu primeiro commit"
``

## Git push
- Enviando as mudanças para o repositório remoto.
``sh
 git push origin main
``
## Git pull
- Atualizando o repositório local.
``sh
 git pull origin main
``


*Thiago*
- Criar uma nova branch com o comando git:
  *git checkout -b feature-thiago*

- Criar classe chamada *ServicoLocacao1*

- Criar as seguintes propriedades:
*DataLocacao:DateTime*
*ValorDiaria:Decimal*
*QuantidadeDiaLocacao:int*
*ValorTotalLocacao:Decimal*
-------------------------------------------------------
*Everton*
- Criar uma nova branch com o comando git:
  *git checkout -b feature-everton*

- Criar classe chamada *ServicoLocacao2*

- Criar as seguintes propriedades:
*DataLocacao:DateTime*
*ValorDiaria:Decimal*
*QuantidadeDiaLocacao:int*
*ValorTotalLocacao:Decimal*

-------------------------------------------------------
Depois que terminarem, usem os seguintes comandos para enviar o código para o repositório do GIT:
1) git add .
2) git commit -am"Finalizacao da tarefa"
3) git push origin feature-"digite seu nome aqui"