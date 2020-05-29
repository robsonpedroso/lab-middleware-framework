# Lab - Middleware com .Net Framework

Projeto para mostrar a utilização um estilo de "Middleware" no .Net Framework.

## Introdução

Essas instruções fornecerão uma cópia do projeto em execução na sua máquina local para fins de desenvolvimento e teste.

### Prerequisitos

O que você precisa para baixar, rodar e disponibilizar.

* .Net Framework 4.7.1
* IDE de sua preferência 

### Instalação

Após a execução do pre requisitos, segue um passo a passo de como rodar localmente.

Clonar o repositório

```
git clone git@github.com:robsonpedroso/lab-middleware-framework.git
```
Abra a solução com o seu IDE (no meu caso Visual Studio) e compile.

### Explicação

Nesse projeto utilizamos o manipularor de mensagens HTTP para interceptar o response antes de retornar para o requisitante.

Criamos uma classe chamada **MessageHandler** na pasta **Handlers** herdando da classe **DelegatingHandler** e sobrescrevendo o metodo **SendAsync**

No arquivo de configuração da API **WebApiConfig.cs** adicionamos nossa classe no Handler de mensagens.

```
	config.MessageHandlers.Add(new MessageHandler());
```

## Publicação

Não foi publicado

## Autores

* **Robson Pedroso** - *Projeto inicial* - [RobsonPedroso](https://github.com/robsonpedroso)

## License

Software feito apenas para fins de estudo

## Ferramentas

* [Dotnet](https://dotnet.microsoft.com/download)