# Abstrair um Jogo de RPG Usando Orientação a Objetos com C# 

## Escopo deste Projeto 

## Adições implementadas:
 * `HP` do personagem.
 * Objetos da classe `Hero` e herdeiros podem batalhar entre si.
 * Cada classe herdeira de `Hero` possui um ataque especial que dá o dobro de dano.
 * Objetos da classe `Hero` e herdeiros podem se casar.
 * Validação para que os personagens não possam agir se estiverem com o `HP` igual a `0`

### **Projeto: Abstraindo um Jogo de RPG Usando Orientação a Objetos com C#**

#### **Introdução:**

O objetivo deste projeto é criar uma abstração de um jogo de RPG usando o paradigma de Orientação a Objetos (OO) em C#. A abstração deve capturar os principais conceitos e funcionalidades de um RPG, como personagens, itens, combate e progressão de nível.

#### **Requisitos:**

- ##### **Conceitos de Orientação a Objetos:** Herança, polimorfismo, encapsulamento e abstração.

- ##### **Linguagem de Programação C#:** Sintaxe, tipos de dados, estruturas de controle e bibliotecas padrão.

- **Conceitos de RPG:** Personagens, itens, combate, experiência e progressão de nível.

#### **Arquitetura:**

O projeto será organizado em várias classes e interfaces que representam os diferentes conceitos do RPG:

- **Personagem:** Classe base para todos os personagens do jogo, com atributos como nome, nível, saúde e mana.
- **Jogador:** Subclasse de Personagem representando o personagem controlado pelo jogador.
- **Inimigo:** Subclasse de Personagem representando os oponentes no jogo.
- **Item:** Classe representando os itens que os personagens podem usar ou equipar.
- **Arma:** Subclasse de Item representando armas que os personagens podem equipar.
- **Armadura:** Subclasse de Item representando armaduras que os personagens podem equipar.

#### **Funcionalidades:**

- **Criação de Personagem:** Os jogadores podem criar um personagem personalizado, escolhendo seu nome e classe.
- **Exploração:** Os jogadores podem explorar um mundo do jogo, interagindo com NPCs e encontrando itens.
- **Combate:** Os jogadores podem se envolver em combates por turnos com inimigos, usando armas e habilidades.
- **Progressão de Nível:** Os personagens ganham experiência ao derrotar inimigos e sobem de nível, melhorando seus atributos e habilidades.

#### **Implementação:**

O projeto será implementado usando C# e as bibliotecas padrão. O código será organizado em vários arquivos para manter a modularidade e a manutenção.

### **Conclusão:**

Este projeto fornecerá uma abstração abrangente de um jogo de RPG usando Orientação a Objetos em C#. Ele demonstrará os conceitos fundamentais de OO, bem como os principais elementos e funcionalidades de um RPG. O projeto pode ser estendido e personalizado para criar jogos de RPG mais complexos e envolventes.