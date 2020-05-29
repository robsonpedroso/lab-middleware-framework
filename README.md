# Lab - Middleware com .Net Framework

Projeto para mostrar a utiliza��o um estilo de "Middleware" no .Net Framework.

## Introdu��o

Essas instru��es fornecer�o uma c�pia do projeto em execu��o na sua m�quina local para fins de desenvolvimento e teste.

### Prerequisitos

O que voc� precisa para baixar, rodar e disponibilizar.

* .Net Framework 4.7.1
* IDE de sua prefer�ncia 

### Instala��o

Ap�s a execu��o do pre requisitos, segue um passo a passo de como rodar localmente.

Clonar o reposit�rio

```
git clone git@github.com:robsonpedroso/lab-middleware-framework.git
```
Abra a solu��o com o seu IDE (no meu caso Visual Studio) e compile.

### Explica��o

Nesse projeto utilizamos o manipularor de mensagens HTTP para interceptar o response antes de retornar para o requisitante.

Criamos uma classe chamada **MessageHandler** na pasta **Handlers** herdando da classe **DelegatingHandler** e sobrescrevendo o metodo **SendAsync**

No arquivo de configura��o da API **WebApiConfig.cs** adicionamos nossa classe no Handler de mensagens.

```
	config.MessageHandlers.Add(new MessageHandler());
```

## Publica��o

N�o foi publicado

## Autores

* **Robson Pedroso** - *Projeto inicial* - [RobsonPedroso](https://github.com/robsonpedroso)

## License

Software feito apenas para fins de estudo

## Ferramentas

* [Dotnet](https://dotnet.microsoft.com/download)