# Design Pattern: Decorator

<img width="1376" height="768" alt="Gemini_Generated_Image_bkhro9bkhro9bkhr" src="https://github.com/user-attachments/assets/4a8d99bb-d59e-472f-b6fd-e3574e5437dc" />

## Integrantes --
**Nome:** Luna Beatriz Alves <br>
**Curso:** Desenvolvimento de Sistemas <br>
**Instrutor:** Frederico Martins Aguiar 

## O que é Design Patterns? --
Design Patterns(Padrões de Projeto) são descrições ou modelos que ajudam a resolver um problema específico, em múltiplas situações. Com o objetivo de fornecer um vocabulário comum para a equipe de desenvolvimento e acelerar o processo, evitando que se perca tempo com problemas já solucionados.

Ele possui cinco princípios de design do padrão **SOLID** para a programação orientada a objetos. Entre eles estão:

* **S** - Single Responsibility Principle (Princípio da Responsabilidade Única): Uma classe deve ter um, e somente um, motivo para mudar.

* **O** - Open-Closed Principle (Princípio Aberto-Fechado): Objetos devem estar abertos para extensão, mas fechados para modificação.

* **L** - Liskov Substitution Principle (Princípio da Substituição de Liskov): Uma classe derivada deve ser substituível por sua classe base.

* **I** - Interface Segregation Principle (Princípio da Segregação de Interface): Clientes não devem ser forçados a depender de interfaces que não utilizam.

* **D** - Dependency Inversion Principle (Princípio da Inversão de Dependência): Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.

## O que é Decorator? --
Decorator é um padrão de projeto estrutural que permite associar novos comportamentos a objetos, colocando esses objetos dentro de objetos encapsulados especiais que contêm os comportamentos, ele permite envolver uma função, método ou classe com comportamentos extras sem modificar seu código original.

Funciona como um wrapper que envolve o objeto ou função original, permitindo executar ações antes ou depois de sua execução, dessa maneira aprimora e estende a funcionalidade de forma limpa e reutilizável.

## Estrutura do Decorator --
### Figura 1 - Representação do padrão Decorator em um Diagrama UML

<img width="700" height="875" alt="Gemini_Generated_Image_vx5yh8vx5yh8vx5y" src="https://github.com/user-attachments/assets/441a8459-a713-40a7-9372-5fe87b269c08" />

### Fonte: Artigo do site Medium

* **ICharacter (O Componente Base)** — É a interface que define onde qualquer personagem pode lutar. Possui métodos de combate como atacar() ou defender().

* **Character (O Componente Concreto)** — Implementação de um personagem básico, sem nenhum equipamento especial, ele pode atacar() com um ataque básico de espada e defender() com um bloqueio simples.

* **Equipment (O Decorator Abstrato)** — Uma capa mágica invisível que tem exatamente o mesmo formato do personagem(ICharacter) e contém um personagem (+decoratedCharacter). Ela tem um ícone misto de espada e escudo, indicando que seu propósito é modificar esses atributos. Ela não adiciona comportamento sozinha, mas define a estrutura para os decoradores concretos.

* **FireSword e MagicArmor (Os Decoratores Concretos)** — Eles são os equipamentos que aplicam os decoradores. Eles estendem Equipment e têm ícones específicos, uma FireSword (Espada de Fogo) que fica no lugar do atacar(), que ao invés de apenas realizar um ataque básico, ela também realiza um ataque extra de fogo e uma MagicArmor (Armadura Mágica), que fica no lugar do defender(), que quando realiza o bloqueio básico ele ativa uma barreira mágica de defesa que aumenta a resistência.

### Figura 2 - Representação do padrão Decorator em uma analogia com o mundo real

<img width="900" height="450" alt="decorator-comic-1-1 5x" src="https://github.com/user-attachments/assets/d6e1c247-3437-4a66-a8fc-7e68d0c5013d" />

### Fonte: Site Refactoring.guru

## Resolução de Problemas --
* **Explosão de subclasses:** Evita a criação de dezenas de classes para combinar funcionalidades diferentes.

* **Código Repetitivo:** Centraliza códigos de infraestrutura que se repetem em várias funções, como logs, validações, autenticação ou controle de tempo de execução.

* **Modificação de código legado:** Permite adicionar comportamentos a funções ou métodos existentes sem a necessidade de modificar o código-fonte original, o que é ideal para manter a estabilidade do sistema.

## Participantes Principais --
* **Componente (Component/Interface):** Define a interface comum para os objetos que podem ter responsabilidades adicionadas dinamicamente.

* **Componente Concreto (ConcreteComponent):** A classe original que define o comportamento básico, ao qual novas funcionalidades podem ser adicionadas.

* **Decorador (BaseDecorator/Decorator):** Mantém uma referência a um objeto componente e implementa a interface do Componente. Ele repassa as chamadas de método para o objeto envolvido e pode executar ações antes ou depois.

* **Decoradores Concretos (ConcreteDecorator):** Classes que estendem o Decorador e adicionam funcionalidades específicas ao componente.

## Justificativa da Escolha --
Inicialmente me interessei por esse padrão, porque o nome me chamou a atenção, pensei que se tratava de um padrão de “Decoração no sentido estético, com isso, baseando-se na pesquisa que me aprofundava, percebi que ele foge desse padrão e decidi conhecer melhor sobre esse padrão do Design Patterns.

## Implementação do Decorator no Projeto --
O Decorator permite adicionar novas funcionalidades, comportamentos ou responsabilidades a um objeto individualmente, em tempo de execução, sem afetar o comportamento de outros objetos da mesma classe.

## IPersonagem:
### Figura 3 - Representação do Código da interface IPersonagem

<img width="2000" height="1414" alt="IPersonagem" src="https://github.com/user-attachments/assets/91045e39-16e8-4190-a3a6-0b43052cfc54" />

### Fonte: Canva
## Guerreiro:
### Figura 4 - Representação do Código do Guerreiro

<img width="2000" height="1414" alt="Guerreiro" src="https://github.com/user-attachments/assets/b1309b11-cd89-4430-bb8e-197a6bf1177f" />

### Fonte: Canva
## EquipamentoDecorator:
### Figura 5 - Representação do Código do Equipamento Decorator

<img width="2000" height="1414" alt="EquipamentoDecorator" src="https://github.com/user-attachments/assets/1eb463c0-3bce-4fa1-963a-bdc718aa9c45" />

### Fonte: Canva
## EspadaDeFogo:
### Figura 6 - Representação do Código do Espada De Fogo

<img width="2000" height="1414" alt="EspadaDeFogo" src="https://github.com/user-attachments/assets/eeab63fa-c55b-48e6-bd16-f5d06833afec" />

### Fonte: Canva
## ArmaduraMagica:
### Figura 7 - Representação do Código da Armadura Mágica

<img width="2000" height="1414" alt="ArmaduraMagica" src="https://github.com/user-attachments/assets/f22ad2ee-2b04-4730-89f8-c73574028f1b" />

### Fonte: Canva

## Análise Crítica --
O padrão Decorator é uma ferramenta poderosa para seguir o Princípio Aberto-Fechado (Open-Closed Principle), permitindo que funcionalidades sejam estendidas sem alterar o código original. No entanto, sua implementação exige cautela:

* **Flexibilidade vs. Complexidade:** Embora ofereça maior flexibilidade que a herança por permitir mudanças em tempo de execução (runtime), ele introduz uma camada de complexidade no rastreamento do fluxo de execução.

* **Gestão de Objetos:** O uso excessivo pode resultar em uma "explosão" de pequenos objetos similares, o que pode dificultar a depuração e aumentar levemente o consumo de memória.

* **Curva de Aprendizado:** Não é um padrão recomendado para desenvolvedores iniciantes, pois a estrutura de "wrappers" (envelopamentos) sobrepostos exige uma compreensão sólida de interfaces e composição.

* **Manutenibilidade:** A dificuldade de remover um decorador específico do meio de uma "pilha" de comportamentos é um ponto negativo relevante para sistemas que exigem alta dinamicidade na reversão de estados.

## Comparação --
* **Decorator vs Herança:** O Decorator é mais flexível (composição), pois permite adicionar/remover funcionalidades em tempo de execução, enquanto a herança é estática.

* **Decorator vs Proxy:** Ambos envolvem um objeto, mas o Decorator adiciona responsabilidades extras, enquanto o Proxy controla o acesso ao objeto original.

* **Decorator vs Composite:** Decorators são versões simplificadas do Composite, focados em adicionar comportamento, não em agrupar.

* **Decorator (Python) vs Anotações (Java):** Decorators são funções/classes executáveis em tempo de execução. Anotações são metadados que dependem de componentes externos para funcionar.

## Vantagens e Desvantagens --
### Vantagens:

* **Flexibilidade e Composição:** Permite estender o comportamento de um objeto em tempo de execução (runtime), adicionando ou removendo funcionalidades sem modificar a classe base.

* **Melhoria da Modularidade e Organização:** Facilita a separação de preocupações, dividindo comportamentos monolíticos em classes menores e focadas.

* **Reutilização de Código:** Funcionalidades transversais, como logs, autenticação, cache ou validação, podem ser encapsuladas em um decorador e aplicadas a diversas funções ou métodos.

* **Evita a Explosão de Subclasses:** Em vez de criar subclasses para cada combinação de comportamento usa-se a composição, empilhando decoradores.

* **Princípio Aberto/Fechado:** O código original permanece fechado para modificação, mas aberto para novas funcionalidades através dos decoradores.

### Desvantagens:

* **Complexidade no Rastreamento:** Com múltiplos decorators em cascata, torna-se difícil entender a ordem de execução e rastrear o fluxo do código.

* **Dificuldade de Depuração:** Como os decorators envolvem objetos em camadas, depurar erros torna-se desafiador, pois o comportamento observado não corresponde diretamente ao código original.

* **Aumento de Pequenos Objetos:** O padrão pode resultar em muitas classes pequenas e semelhantes, o que pode aumentar a complexidade e o consumo de memória.
Remoção de Wrapper: É difícil remover um decorador específico de uma pilha de componentes, pois ele é encapsulado.

* **Ordem de Dependência:** Implementar decoradores onde o comportamento não dependa da ordem na pilha pode ser complicado.

---

| Vantagens | Desvantagens |
|-----------|--------------|
| Alto grau de flexibilidade | Alta complexidade do software (especialmente da interface do decorador) |
| Expansão da função de classes sem herança | Não é adequado para iniciantes |
| Código de programa legível | Grande número de objetos |
| Funcionalidades otimizadas em termos de recursos | Processo de depuração difícil |

---
## Aplicação Real no Mercado --
No mercado de desenvolvimento de software, o Decorator não se limita apenas a exemplos lúdicos de jogos (como o personagem com espada de fogo ). Ele é amplamente utilizado em infraestruturas de sistemas robustos:

**Modelos de Uso Comum:**
* **Sistemas Bancários e de E-commerce:** Para adicionar dinamicamente taxas, descontos ou métodos de entrega a um pedido sem criar uma classe para cada combinação possível.

* **Middleware de Web APIs:** Utilizado para injetar funcionalidades transversais, como logs, autenticação, cache e validação de dados em rotas específicas sem poluir a lógica de negócio principal.

* **Processamento de Streams (I/O):** É o modelo clássico do Java (ex: BufferedReader envolvendo um FileReader), onde cada classe adiciona uma funcionalidade de leitura diferente ao fluxo básico.

* **Interfaces Gráficas (GUI):** Adição de barras de rolagem ou bordas a janelas de forma dinâmica, dependendo da necessidade do usuário em tempo de execução.

## REFERÊNCIAS --

CHAGAS,  Igor. **Design Patterns: o guia definitivo dos Padrões de Projeto**. Alura, 21 out. 2021 . Disponível em:<https://www.alura.com.br/artigos/design-patterns-introducao-padroes-projeto?srsltid=AfmBOoqD6KC-JIacdKtf7OBQ_aLb04I8dVvvIbmj6LH5vRSYTMEKZo5K>.Acesso em: 20 mar. 2026.

CLÍMACO, Vinicius. **Design Pattern: Decorator**. Medium, 10 out. 2022. Disponível em:<https://climaco.medium.com/design-pattern-decorator-b0ba34ff9da5>.Acesso em: 20 mar. 2026.

GORIN, Maxim. **Por que adicionar funcionalidades não deve quebrar seu código: Conheça o padrão Decorator**. Medium, 22 abril. 2025. Disponível em:<https://maxim-gorin.medium.com/why-adding-features-shouldnt-break-your-code-meet-the-decorator-pattern-3c8875d6232c>.Acesso em: 20 mar. 2026.

GURU, Refactoring. **Decorator**. Refactoring.Guru. Disponível em:<https://refactoring.guru/pt-br/design-patterns/decorator>.Acesso em: 23 mar. 2026.

MIMO. **Decorator: Definition, Purpose, and Examples**. Mimo. Disponível em:<https://mimo.org/glossary/programming-concepts/decorator>.Acesso em: 23 mar. 2026.

PARTNERS, Curate. **Entendendo o padrão Decorator: aprimorando a flexibilidade no design de software**. Curate Partners. Disponível em:<https://curatepartners.com/tech-skills-tools-platforms/understanding-the-decorator-pattern-enhancing-flexibility-in-software-design/>.Acesso em: 23 mar. 2026.

SAMPAIO, Milton. **Padrões de Projeto - Design Patterns - Decorator**. YouTube. Disponível em:<https://youtu.be/7qvKUNuq5vo?si=UT-HxdODbYyOogK_>.Acesso em: 23 mar. 2026.
