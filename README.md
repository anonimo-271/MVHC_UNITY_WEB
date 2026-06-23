# MVHC — Unity WebGL Build

Este repositório contém a build WebGL do **Museu Virtual da História da Computação**, gerada pelo Unity e hospedada via GitHub Pages.

## Acesso

A experiência 3D é acessada diretamente pelo navegador, sem necessidade de instalação:

**[Acessar o Museu Virtual](https://anonimo-271.github.io/MVHC_UNITY_WEB/)**

## Sobre

O ambiente 3D foi desenvolvido no Unity e exportado como WebGL. Ao abrir o link, o navegador carrega o build e permite ao usuário navegar pelo museu virtual em tempo real.

## Estrutura

```
├── index.html        # Página de entrada da build
├── Build/            # Arquivos compilados pelo Unity (WebGL)
├── TemplateData/     # Assets do template de carregamento
└── Unity_Scripts/    # Scripts C# utilizados no projeto
```

## Requisitos para rodar localmente

Por limitações do WebGL, o build precisa ser servido via servidor HTTP:

```bash
python -m http.server 8080
```

Acesse `http://localhost:8080` no navegador.
