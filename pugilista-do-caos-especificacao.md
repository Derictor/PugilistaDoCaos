# Pugilista do Caos

## A escola de Helden Yulden

Classe de origem humana com o punho enfaixado como símbolo. Helden é o primeiro mestre e um recruta único. Sua ficha privilegia Wits e Força excepcionais, Percepção e resistência mental muito altas e capacidade de carga extraordinária. Destino e Misticismo ficam quase nulos. Ânimo Inabalável pertence a Helden, com Moral alta e apoio mental a um aliado. Aprendizes podem dominar as técnicas físicas e conservam sua identidade racial.

- **Guerreiros adultos.** No treino do acampamento, selecionar um guerreiro presente e ensinar as técnicas da escola, conservando profissão, raça, nível e habilidades já aprendidas. A proposta deixa o requisito 5/3/3 para o amadurecimento.
- **Crianças.** Qualquer raça jogável com amadurecimento pode seguir a escola ao crescer. Testar **Força ≥ 5, Percepção ≥ 3 e Sabedoria ≥ 3** no mesmo candidato. Proponho contar atributos permanentes, para que um bônus temporário não habilite a opção. Oferecer a escolha quando Helden estiver disponível e preservar as outras escolhas de amadurecimento. O aprendiz adulto resultante precisa conservar nome, raça e traços raciais. O perfil de Helden é exclusivo do recruta.
- **Cooperativo.** Identificar o dono do candidato e aplicar o treino a um personagem de cada vez. Bloquear treino duplicado. No recrutamento, conceder um único Helden ao grupo escolhido. Testar ambos os jogadores, inclusive depois de salvar e reabrir a campanha.

## Encontros

- **O Peso da Volta.** Helden segura a viga de um celeiro que está cedendo. Uma rota física abre caminho sob a viga. Uma rota de Percepção encontra uma saída lateral ao custo de abandonar parte do grão. Helden oferece suas luvas e se junta ao grupo depois que os sobreviventes estão a salvo.
- **A Primeira Guarda.** Depois do recrutamento, um guerreiro pede para treinar e uma criança tenta imitar o passo. Helden abre duas rotas, a aula do adulto no acampamento e a escolha de classe na idade adulta. A primeira graduação entrega Faixas de Mão. Exemplo de fala: “Vai errar o passo. Todo mundo erra. Volta e tenta mais uma vez.”
- **A Luva do Pesadelo.** Na noite de Halloween, lanternas iluminam uma luva de dedos laminados numa carvoaria abandonada. Helden sustenta o ânimo do grupo enquanto um companheiro entende o presságio. A recompensa é a luva. A cópia de referência tem conteúdo sazonal, mas o gatilho do encontro novo ainda precisa ser ligado e testado.

## Técnicas

- **Passo em Falso.** Prioridade para esquiva física determinística. Investigar o ponto de interceptação do dano e testar primeiro ataque direto, golpes seguintes, múltiplos alvos, expiração e sincronização. A habilidade chamada Evade Orders na base é Battle Orders, e o nome sozinho não confirma esquiva.
- **Golpe de Encontro.** Golpe rápido que aumenta o atraso do alvo, aproveitando efeito existente na base.
- **Estopim.** Uma vez por combate, após um aliado perder vida por um ataque, Helden pode usar um golpe rápido e abrir mão da esquiva até a próxima ação. A escola pode ensinar a técnica.
- **Ânimo Inabalável.** Moral alta, perda reduzida de Moral e proteção mental a um companheiro como ação em desafio mental.
- **Segundo Fôlego.** Se a esquiva for inviável, usar proteção física alta com recuperação parcial de armadura mediante ação. A base possui Act_AddShielding. Limite, alvo e duração exigem teste.

## Equipamentos e materiais

| Item | Origem e material propostos |
|---|---|
| Luvas de Helden | Equipamento inicial. Reposição com couro. |
| Soco-Inglês de Forja | Fabricação com ferro e couro. |
| Garra da Máscara | Receita de um duelista. Ferro e couro. |
| Garras Triplas | Fabricação com aço e couro. |
| Garras Duplas | Fabricação com ferro ou aço e couro. |
| Luva do Pesadelo | Recompensa sazonal. |
| Faixas de Mão | Graduação e fabricação com couro macio ou tecido, se aprovado. |
| Faixa de Cabeça da Escola | Graduação. Proteção mental como efeito a testar. |
| Calças do Lutador | Peça visual de um traje leve, com reforços de couro. |
| Quimono de Treino | Traje leve de inspiração no karatê. Couro leve ou tecido, se aprovado. |
| Quimono Reforçado | Traje inspirado no judô e jiu-jítsu, com couro reforçado. A seda RES-WYRM_SILK cabe como opção de nível alto. |
| Arnês de Travessia | Fabricação com couro. Bônus de carga a testar. |

A cópia consultada confirma ferro, aço e couro, e confirma que uma receita pode ocupar LeftHand e RightHand. Luvas, soco-inglês, faixas de mão e garras seguem esse padrão. Encontrei um espaço Armour nas receitas de equipamento, sem espaços separados para cabeça e pernas. A proposta é ter faixa e calças no visual do traje, e testar se a faixa pode ser oferecida como acessório opcional.

**Material de mapa para decidir.** Se você quiser faixas e quimonos de tecido já no começo, faz sentido acrescentar **linho silvestre**, com coleta nas margens dos rios, arte de mapa e ícone de inventário. O linho abasteceria as faixas e o quimono de treino. A cópia consultada tem seda avançada, mas não encontrei linho ou tecido comum na base de recursos. O linho ainda é uma proposta.

## Conferência técnica

A revisão usou uma cópia local de DataBase, Modules e Scripts extraída para o projeto anterior. O sandbox bloqueou o acesso direto à instalação em D:. A referência contém FMO_ChangeLearnedSkillOnCharacter para aprendizagem e FMO_UpgradeToSubrace para amadurecimento. O caminho para outras raças precisa respeitar as variantes raciais. O projeto usa IDs próprios e depende do jogo base.

Antes de empacotar uma versão jogável, conferir:

- Classe e variantes raciais, fichas e progressão, nomes e descrições em português, retrato, símbolo e modelo humano nativo em mapa. Validar retrato, cena e modelo separadamente.
- Resolução de todos os IDs e vínculos, incluindo classe, habilidades, sub-habilidades, tags, scripts, texturas, receitas, cargas de item, eventos e localização. Testar telas de personagem, pesquisa, fabricação e inventário.
- Ilustração e gatilho de recrutamento, treino e Halloween. As artes do duelista e os ícones de Golpe de Encontro e Segundo Fôlego já estão no pacote. Vincular cada arte ao seu registro no jogo.
- Limiares 5/3/3. Testar 5/3/3, 4/3/3, 5/2/3, 5/3/2 e candidatos com bônus temporário ou em grupos diferentes. Confirmar que o amadurecimento conclui uma única vez e conserva as opções originais.
- Ciclo de cada item: obter material, desbloquear receita, consumir os ingredientes esperados, fabricar ou receber a recompensa, equipar, usar a habilidade e verificar ocupação das duas mãos.
- Só depois de ativar no jogo: verificar logs de carregamento, campanha solo, campanha cooperativa, salvamento e recarregamento. As artes e esta especificação ainda não formam um mod instalável.


## Direção das artes

O gerador de imagens integrado usou o retrato de Helden como referência para as cenas. Os pedidos mostraram o resgate no celeiro nevado, o treino ao redor da fogueira com aprendizes de vários povos, a luva pendurada na carvoaria no Halloween e a negociação com o duelista mascarado junto à forja. Os ícones foram pedidos como silhuetas de fantasia sombria, com fundo escuro e detalhes em marfim e cobre. O punho enfaixado tem duas versões. Os equipamentos seguem o visual de couro gasto, tecido remendado e metal do jogo.
