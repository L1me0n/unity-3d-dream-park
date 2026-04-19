# Dream Park Prototype

## Project Overview

**Dream Park Prototype** is a small third-person 3D portfolio game prototype built around a dreamlike theme park structure.

The player controls a child who is dreaming. In the center of the dream is a **red escape door with five locks**. To wake up and escape the dream, the player must travel through five themed park sections, complete each section's core challenge, collect its key, and return to unlock the door.

The five sections are:

* **Medieval Park**
* **Wild West Park**
* **Dinosaurs Park**
* **Pirates Park**
* **Olympus Park**

This project is designed as a **small vertical-slice anthology prototype**, not a full commercial game. Each park is a short, focused gameplay slice built around one main mechanic or gameplay fantasy.

The main portfolio value of the project is that it demonstrates a range of 3D gameplay systems inside one coherent wrapper:

* third-person movement and interaction
* melee combat
* ranged duel mechanics
* stealth and distraction systems
* mounted traversal
* cannon defense encounter
* memory-based puzzle gameplay
* hub-and-spoke progression structure

---

## Core Vision

The game should feel like a **storybook dream adventure inside a toy-like theme park**.

It should not aim for realism, large-scale exploration, or deep simulation. Instead, it should focus on:

* clear objectives
* memorable themed spaces
* short and polished gameplay slices
* readable mechanics
* strong visual identity through color, silhouettes, and lighting

The experience should feel like moving through a set of dream attractions, each with its own fantasy and gameplay rule.

---

## High-Level Game Structure

The game uses a **hub-and-spoke structure**.

### Central Hub

The player begins in the dream theme park hub.

The hub contains:

* the **red escape door** with five locks
* entrances to the five park sections
* visual feedback showing which keys or locks have already been completed

### Main Objective

Complete all five park sections and collect all five keys.

Once all locks on the red door are opened, the player unlocks the door, exits the dream, and the child wakes up.

### Core Gameplay Loop

1. Enter a park section from the hub
2. Complete the section's challenge
3. Receive the section key
4. Return to the hub
5. Unlock one of the five locks on the red escape door
6. Repeat until all five keys are collected
7. Open the red door and trigger the ending

---

## Design Pillars

### 1. Strong Theme and Readability

Each section must be immediately recognizable and visually distinct, even with prototype assets.

### 2. One Main Mechanic per Park

Each park should focus on one primary gameplay fantasy and avoid feature overload.

### 3. Small, Controlled Scope

Each park should be short, compact, and intentional. No large open maps.

### 4. Prototype-Friendly Production

The project should be built using greyboxing, placeholder assets, simple animations, and readable level design.

### 5. Variety Inside One Cohesive Game

The sections should feel different from one another, but all belong to the same dream-theme-park concept.

---

## Camera and Perspective

The game is played in **third-person view**.

The player character is visible on screen at all times during gameplay.

Third-person view should support:

* movement and exploration
* interaction with NPCs and objects
* melee combat
* mounted riding
* stealth navigation
* cinematic clarity during park-specific sequences

---

## Core Player Systems

These are the foundational systems used across the project.

### Player Movement

* third-person movement
* character rotation aligned with movement or camera direction
* basic jumping when required
* interaction input on **E**

### Interaction System

Used for:

* talking to NPCs
* mounting the horse
* picking up weapons or items
* triggering park-specific actions

### Checkpoint / Retry Logic

Each park can define a simple local retry point.

Examples:

* Medieval Park respawns the player before the knight fight if the player dies
* other parks may reset the challenge or section state on failure

### UI

Minimal prototype UI should include:

* basic prompts such as "Press E to interact"
* objective text when needed
* simple success/failure popups
* visual lock/key progression for the red escape door

---

## Park Breakdown

# 1. Medieval Park

## Core Fantasy

The player enters a medieval valley, rides a horse to a castle, defeats five knights, frees a princess, and receives the key.

## Section Flow

1. Player enters Medieval Park
2. Player spawns in a valley
3. A castle is visible far ahead
4. A horse stands next to the player
5. The player character says: **"The key is probably in the castle."**
6. The player mounts the horse with **E**
7. The player rides forward to the castle
8. The player enters the castle main hall
9. A princess is seen inside a cage and five knights are present
10. The player finds a sword on the floor
11. The player picks up the sword
12. Combat begins
13. The player defeats all five knights
14. The princess is freed
15. The princess thanks the player and gives the key
16. The player returns to the hub

## Level Structure

* narrow or controlled valley start
* mountains on both sides to block exploration 
* return door to theme park behind the player
* player cannot ride the horse into the return door
* forward-focused path leading to the castle
* castle main hall used as the combat arena

## Main Mechanics

* horse mounting
* horse riding
* melee weapon pickup
* sword combat against knights
* local respawn before combat if the player dies

## Scope Boundaries

Included:

* simple horse traversal from valley to castle
* one indoor fight arena
* one princess rescue outcome

Not included:

* open-world riding
* mounted combat
* advanced enemy tactics
* full medieval level exploration
* inventory systems

## Portfolio Value

This section demonstrates:

* third-person traversal
* simple vehicle or mount interaction
* melee combat encounter setup
* combat retry flow

---

# 2. Wild West Park

## Core Fantasy

The player enters a saloon, investigates a murder through dialogue, accuses suspects by dueling them, and must kill the real murderer to earn the key.

## Section Flow

1. Player enters Wild West Park
2. Player starts at the entrance to a saloon
3. Player enters the saloon
4. Inside are tables, a bar, the sheriff, bartender, and multiple suspects
5. Player can interact with the bartender using **E**
6. Bartender tells the player to speak to the sheriff
7. Sheriff is located at the far end of the saloon
8. Player interacts with the sheriff
9. Player asks for help finding the key
10. Sheriff explains that there has been a murder and the player must find the killer first
11. Player can then interact with the saloon characters
12. Each character has dialogue options
13. Each character also has a **duel choice**, which acts as an accusation of murder
14. If duel is chosen, the player must go outside to the marked duel spot
15. When the player reaches the marked spot, the duel sequence begins
16. The duel includes a countdown, taking out the gun with **E**, and timing the shot correctly
17. If the player wins the duel, a result popup appears:

* **green popup** if the killed person was the murderer
* **red popup** if the killed person was innocent

18. The player continues investigating until the real killer is found and defeated in a duel
19. Sheriff rewards the player with the key
20. Player returns to the hub

## Dialogue Structure

Each suspect contains:

* 3 dialogue lines or dialogue branches
* 1 duel option

Dialogue is used to:

* reveal suspect personalities
* provide hints or contradictions
* build suspicion
* create guilt if the player kills innocent people

## Duel Structure

Duel flow:

* accuse suspect
* move outside
* stand at marked spot
* countdown begins
* draw gun on **E**
* fire with correct timing
* determine duel result

## Main Mechanics

* NPC interaction
* dialogue choices
* suspect elimination logic
* duel minigame
* correct/incorrect accusation feedback

## Scope Boundaries

Included:

* one saloon interior
* one outdoor duel area
* a small cast of suspects
* lightweight dialogue system
* one correct killer per playthrough or fixed killer depending on scope decision

Not included:

* large town exploration
* branching narrative outcomes beyond key progression
* deep reputation system
* full shooter combat system beyond duels

## Portfolio Value

This section demonstrates:

* dialogue interaction systems
* choice-driven gameplay
* suspicion and deduction structure
* timing-based ranged mechanic

---

# 3. Dinosaurs Park

## Core Fantasy

The player sneaks through a dinosaur field using tall grass, then uses frogs as distractions, then survives a chase and escapes over a waterfall to reach the key.

## Section Flow

### Part 1: Tall Grass Stealth

1. Player enters Dinosaurs Park
2. Dinosaurs patrol a field
3. Some field tiles contain tall grass
4. Tall grass hides the player from dinosaurs
5. The player must time movement between grass patches and open spaces

### Part 2: Frog Distraction

6. The player reaches the second area
7. The player obtains frogs
8. Dinosaurs block the path forward
9. The player throws or shoots frogs in chosen directions to distract dinosaurs
10. While dinosaurs are distracted, the player advances

### Part 3: Chase Sequence

11. Near the end of the second area, a dinosaur detects the player
12. A chase sequence begins
13. The player must rapidly press **W** to run away
14. The player reaches a cliff with a waterfall
15. The player jumps down with **Space**
16. The dinosaur is escaped
17. At the bottom of the waterfall, the player finds the key
18. The player returns to the hub

## Main Mechanics

* stealth using line-of-sight blockers
* patrol awareness behavior
* distraction item use
* chase event
* scripted escape finish

## Scope Boundaries

Included:

* one stealth field
* one distraction section
* one chase finale
* one waterfall escape

Not included:

* combat against dinosaurs
* large survival systems
* complex stealth skill trees
* multiple chase routes

## Portfolio Value

This section demonstrates:

* stealth rules
* patrol AI
* distraction mechanics
* chase event design
* sequence-based pacing

---

# 4. Pirates Park

## Core Fantasy

The player defends their ship using a cannon while pirates try to board by crossing narrow planks from another ship. After defeating them, the player boards the second ship and takes the key.

## Section Flow

1. Player enters Pirates Park
2. Player starts on a ship
3. A second pirate ship is connected by narrow planks
4. Pirates attempt to cross the plank to board the player's ship
5. The player uses a cannon to shoot the pirates
6. The cannon has a reload delay
7. The player must defeat all attacking pirates
8. After the fight, the player boards the second ship
9. The key is located there
10. Player returns to the hub

## Main Mechanics

* cannon aiming
* cannon firing
* reload timing
* wave defense encounter
* short boarding payoff

## Scope Boundaries

Included:

* two ships
* two attack lanes via plank
* simple pirate rush behavior
* cannon-only defense encounter

Not included:

* full naval movement
* sword fighting on the pirate ships unless added later
* ship steering
* large ocean exploration

## Portfolio Value

This section demonstrates:

* turret-style aiming and shooting
* enemy wave management
* encounter pacing
* compact defense scenario design

---

# 5. Olympus Park

## Core Fantasy

The player climbs a mountain by memorizing a disappearing sequence of symbol tiles. Three successful rounds lead to the summit and the key.

## Section Flow

1. Player enters Olympus Park
2. The player begins at the base of a mountain path or stair path
3. At the top, a sequence of symbols is shown briefly
4. The sequence remains visible for a few seconds
5. The sequence disappears
6. The player must climb the mountain while stepping only on tiles matching the shown sequence in the correct order
7. If the player fails, the puzzle restarts from the beginning with a new random sequence
8. If the player succeeds, the next round begins
9. The player must complete 3 total rounds
10. After the third successful sequence, the player reaches the summit
11. The key is located at the top
12. Player returns to the hub

## Main Mechanics

* memory-based puzzle logic
* sequence generation
* tile validation
* multi-round progression
* full reset on failure

## Scope Boundaries

Included:

* one mountain path
* one symbol system
* three puzzle rounds

Not included:

* combat in Olympus
* open exploration
* multiple puzzle types

## Portfolio Value

This section demonstrates:

* puzzle logic
* random or structured sequence systems
* state reset and retry behavior
* non-combat challenge design

---

## Red Escape Door

The red door is the game's central objective anchor.

### Function

* visually communicates the final goal from the start
* contains five locks
* each collected key unlocks one lock
* after all five locks are opened, the player can interact with the door to finish the game

### Ending

When all locks are opened and the player uses the red door:

* the dream ends
* the child wakes up
* the game concludes

---

## Intended Scope

This project should stay **small**.

### Target Experience Length

Approximately **20 to 35 minutes** total for a first playthrough.

### Target Size Per Park

Each park should feel like a compact gameplay attraction, not a full level-heavy chapter.

Recommended feel:

* Medieval: short intro ride + one combat room
* Wild West: one saloon + one duel area
* Dinosaurs: one field split into clear sections
* Pirates: one encounter arena on ships
* Olympus: one mountain puzzle path

### Project Type

This is a **portfolio prototype**, not a content-heavy production game.

---

## Art Direction Approach

Because the project is prototype-focused and the creator is not an artist, the art direction should be built around **intentional simplicity**.

### Visual Strategy

* greybox-first development
* simple shapes and readable layouts
* stylized color coding per park
* strong lighting and silhouettes
* limited props used carefully

### Park Color Identity Ideas

* Medieval: stone gray, royal blue, warm torchlight
* Wild West: dusty brown, orange, sunset tones
* Dinosaurs: deep green, wet jungle tones, fog
* Pirates: dark wood, ocean blue, cannon smoke
* Olympus: white stone, gold accents, sky glow

### Asset Philosophy

Use:

* simple prototype environment assets
* free placeholder props and characters
* readable world landmarks
* minimal but deliberate UI

Do not depend on:

* custom art production
* complex character modeling
* high-end animation pipelines

---

## Animation Approach

This project should use a **practical placeholder animation workflow**.

### Recommended Approach

Use free or accessible humanoid animations for:

* idle
* walk/run
* mount or simple interaction
* sword attack
* hit reaction
* death
* pistol draw/fire pose
* basic crouch or stealth movement if needed

### Important Principle

Animation quality should be **good enough to support readability**, not a production bottleneck.

The game's value comes from gameplay structure and implementation, not bespoke animation art.

---

## Technical Goals

The prototype should aim to showcase the following technical areas:

* third-person controller
* interaction system
* local mission state per park
* combat state and retry flow
* dialogue choice handling
* duel timing system
* stealth detection and distraction logic
* turret/cannon encounter logic
* memory puzzle validation
* hub progression and key tracking
* final door unlock condition

---

## What This Project Is Not

To protect scope, this project is **not**:

* an open-world game
* a large narrative RPG
* a realistic horse simulator
* a full stealth game
* a full shooter
* a naval combat game
* a cinematic story-heavy production

It is a **small themed prototype game with five compact gameplay slices**.

---

## Production Philosophy

Build the project in layers.

### Layer 1: Foundation

* project setup
* folder structure
* third-person controller
* camera
* interaction prompts
* hub prototype

### Layer 2: Hub and Progression

* red door
* five park entrances
* key tracking
* return flow

### Layer 3: Park-by-Park Gameplay

Implement one park at a time as a self-contained slice.

Recommended build order:

1. Medieval Park
2. Pirates Park
3. Olympus Park
4. Dinosaurs Park
5. Wild West Park

This order starts with simpler, more contained mechanics before moving into stealth and dialogue complexity.

### Layer 4: Polish

* UI cleanup
* simple audio feedback
* park-specific atmosphere
* visual lock feedback on red door
* ending sequence

---

## Success Criteria

The project is successful if it delivers:

* one cohesive dream-theme-park prototype
* a playable hub with five entrances
* all five keys collectible
* one clear mechanical identity per park
* a final ending through the red escape door
* strong portfolio demonstration of varied 3D systems

---

## Phase-by-Phase Development Plan

This plan is designed to keep the project small, modular, and portfolio-focused.

The goal is to build the game in layers, making sure the foundation is solid before adding park-specific mechanics.

---

### Phase 0. Project Setup and Production Foundation

**Goal:** Create a clean starting structure for the prototype.

#### Main Tasks

* create the Unity project
* define folder structure
* set up scenes
* import any essential placeholder assets
* set up input actions or chosen input workflow
* define naming conventions for scripts, prefabs, and scenes
* create a simple development test scene

#### Recommended Outputs

* working project with organized folders
* base scene setup
* placeholder character model imported
* placeholder environment assets ready

#### Scope Note

No gameplay complexity yet. This phase is only about creating a clean production base.

---

### Phase 1. Third-Person Controller and Camera Foundation

**Goal:** Build the player's basic movement and readable third-person presentation.

#### Main Tasks

* implement third-person movement
* implement character rotation behavior
* implement jump if required for the project
* create third-person follow camera
* add camera collision handling if needed
* ensure movement feels readable and responsive

#### Recommended Outputs

* playable third-person controller
* stable camera
* placeholder character moving correctly in a basic scene

#### Scope Note

Do not add combat, interactions, or park logic yet. This phase is only about movement and camera feel.

---

### Phase 2. Interaction System and Hub Prototype

**Goal:** Create the common interaction layer and the first version of the central theme park hub.

#### Main Tasks

* create interaction prompt system
* implement interact input on **E**
* create first hub scene blockout
* place red escape door in hub
* create five park entrances or portals
* create simple return flow between hub and parks

#### Recommended Outputs

* working interaction system
* hub scene with readable layout
* entrances to all five parks present, even if they lead to placeholder scenes
* red door present as the project's main anchor

#### Scope Note

At this stage the red door does not need full progression logic yet. The priority is layout and flow.

---

### Phase 3. Core Progression Framework

**Goal:** Build the systems that track keys, lock states, park completion, and final game completion.

#### Main Tasks

* create key collection system
* track which park keys are collected
* update lock visuals on the red escape door
* allow player to unlock locks when keys are obtained
* create final completion check for all five keys
* set up simple ending trigger logic

#### Recommended Outputs

* game can remember completed parks
* red door reflects progression
* final condition for opening the door exists

#### Scope Note

This phase gives the whole project its backbone. Park content can now plug into a real progression structure.

---

### Phase 4. Medieval Park

**Goal:** Build the first complete park slice, focused on horse traversal and melee combat.

#### Main Tasks

* block out the valley
* block out the castle approach and castle hall
* place return door and mountains for path restriction
* implement horse interaction and mounting on **E**
* implement simple horse riding forward to castle
* create sword pickup interaction
* create knight encounter setup with five knights
* implement basic melee combat against knights
* create princess reward interaction
* create local respawn before fight if the player dies
* award the Medieval key on success

#### Recommended Outputs

* one complete playable park from start to key reward
* first full example of a park returning value to the hub progression system

#### Scope Note

Keep horse usage simple and controlled. This is not a general-purpose horse simulation.

---

### Phase 5. Pirates Park

**Goal:** Build a compact defense-style park with cannon combat and clear encounter pacing.

#### Main Tasks

* block out both ships and the connecting plank
* implement cannon interaction
* implement cannon aim and fire behavior
* add reload delay
* create pirate rush behavior toward the player ship
* build wave logic or single encounter logic
* allow player to board second ship after victory
* place and award the Pirates key

#### Recommended Outputs

* short complete defense sequence
* distinct gameplay flavor compared to Medieval Park

#### Scope Note

Keep the park small. No ship steering, no ocean exploration, no extra combat layer unless later justified.

---

### Phase 6. Olympus Park

**Goal:** Build the non-combat puzzle park focused on sequence memory and tile validation.

#### Main Tasks

* block out mountain path or stair path
* create symbol tile system
* implement sequence display at the top
* hide sequence after a short delay
* validate tile stepping order
* reset puzzle on failure with new sequence
* build three total puzzle rounds
* place and award the Olympus key at the summit

#### Recommended Outputs

* one complete puzzle park with replay/reset behavior
* first strong non-combat slice in the project

#### Scope Note

Avoid adding extra puzzle types. One memorable puzzle system is enough.

---

### Phase 7. Dinosaurs Park

**Goal:** Build the stealth-and-chase park with escalating tension.

#### Main Tasks

* block out stealth field and second area
* define tall grass stealth zones
* create dinosaur patrol behavior
* implement player hidden state in tall grass
* create frog pickup or frog-use mechanic
* implement frog distraction logic
* define detection trigger near the end of the section
* build chase sequence using rapid forward input
* implement cliff and waterfall escape
* place and award the Dinosaurs key at the bottom

#### Recommended Outputs

* complete stealth park with three-part pacing: sneak, distract, flee

#### Scope Note

Keep dinosaur behavior readable and simple. This does not need to become a full stealth AI sandbox.

---

### Phase 8. Wild West Park

**Goal:** Build the most dialogue-heavy park, centered on suspicion, accusation, and duels.

#### Main Tasks

* block out saloon interior and duel exterior
* create bartender interaction
* create sheriff interaction and murder setup
* build suspect interaction framework
* create dialogue UI or simple dialogue presentation
* define 3 lines or branches per suspect
* implement duel choice as accusation
* implement duel staging: marked spot, countdown, draw, shoot timing
* create success/failure or correct/incorrect accusation popup feedback
* define killer logic
* award the Wild West key when the true killer is defeated

#### Recommended Outputs

* complete suspect-investigation park with duel mechanic

#### Scope Note

This is likely the most complex park in logic terms. Keep the suspect cast small and the dialogue system lightweight.

---

### Phase 9. Park Flow Polish and Return Logic

**Goal:** Make all parks feel consistently integrated into the hub and progression flow.

#### Main Tasks

* ensure each park cleanly returns to the hub
* add park completion feedback in hub
* polish key collection presentation
* polish lock opening presentation
* ensure each park resets or preserves state correctly based on design
* test replay prevention or replay behavior if needed

#### Recommended Outputs

* all five parks feel connected to one real game loop rather than disconnected scenes

#### Scope Note

This phase is about cohesion, not new mechanics.

---

### Phase 10. UI, Feedback, and Atmosphere Pass

**Goal:** Improve readability, feedback, and presentation without exploding scope.

#### Main Tasks

* polish interaction prompts
* polish objective text
* add success/failure popups where needed
* add simple health feedback if applicable
* add lock/key UI or visual progression feedback
* add simple sound effects
* add simple park-specific music or ambience if available
* improve lighting and color identity per park

#### Recommended Outputs

* the project feels readable and intentionally presented
* each park has a stronger identity even with placeholder assets

#### Scope Note

This is a polish pass, not a content-expansion phase.

---

### Phase 11. Ending Sequence and Final Presentation

**Goal:** Complete the project loop and make it portfolio-ready.

#### Main Tasks

* implement final interaction with red escape door
* create wake-up ending sequence
* add end screen or completion screen
* test full game flow from start to finish
* fix progression bugs and edge cases
* build playable portfolio version

#### Recommended Outputs

* fully playable beginning-to-ending prototype
* clean portfolio-ready build

---

### Optional Phase 12. Extra Polish or Stretch Improvements

This phase should happen only if the core game is already complete.

Possible optional additions:

* better animation blending
* better park transitions
* minor cinematic intro/outro moments
* extra environmental props
* improved dialogue presentation in Wild West
* better combat feedback in Medieval
* better chase feedback in Dinosaurs

#### Scope Warning

This phase is optional by design. The project should already be successful before this phase begins.

---

## Suggested Build Order Rationale

The order is intentionally chosen to control risk:

1. **Foundation first** so all later work plugs into stable systems.
2. **Medieval first** because it establishes the first full park and proves the project structure.
3. **Pirates and Olympus next** because they are compact and manageable.
4. **Dinosaurs after that** because stealth logic is more complex.
5. **Wild West last** because dialogue plus suspicion logic plus duel flow makes it the trickiest park.

This order reduces the chance of getting stuck early on the hardest content.

---

## Recommended Phase Categories

For implementation pacing, phases can be treated in three larger groups.

### Group A. Foundation

* Phase 0
* Phase 1
* Phase 2
* Phase 3

### Group B. Content Production

* Phase 4
* Phase 5
* Phase 6
* Phase 7
* Phase 8

### Group C. Finalization

* Phase 9
* Phase 10
* Phase 11
* Optional Phase 12

---

## Phase-by-Phase Implementation Plan

The project should be implemented in small, controlled phases. Each phase should end in a playable state whenever possible.

The goal is not to rush into all five parks immediately. The goal is to first create a stable project foundation, then make the hub and progression work, and then build each park as a compact gameplay module.

---

### Phase 0: Pre-Production Lock-In

**Goal:** Lock the project structure before implementation begins.

**Main tasks:**

* finalize the README as the project reference source
* decide project name if it changes later
* define folder structure
* define scene structure
* define naming conventions
* define the minimal art direction and prototype rules
* define the initial control scheme

**Deliverables:**

* approved README blueprint
* agreed project scope boundaries
* technical direction for prototype production

**Notes:**
This phase is mostly planning and setup discipline. It prevents the project from becoming messy later.

---

### Phase 1: Project Foundation and Third-Person Core

**Goal:** Build the base player experience used across the whole game.

**Main tasks:**

* create the Unity project structure
* set up core folders for scenes, scripts, prefabs, materials, UI, audio, and prototype assets
* create a basic test scene
* implement third-person player controller
* implement third-person camera
* set up player movement
* set up jumping if needed
* set up interaction input on **E**
* create a simple interaction prompt system
* set up basic player state foundation if needed

**Deliverables:**

* playable third-person character
* working camera
* interact prompt on usable objects or NPCs
* stable test scene for future system testing

**Why this phase matters:**
All parks depend on this. If the base controller feels bad, the whole project suffers.

---

### Phase 2: Hub World and Global Progression

**Goal:** Build the dream theme park hub and the overall progression loop.

**Main tasks:**

* create the central hub scene
* place the red escape door in the hub
* create five park entrances or portals
* create a key tracking system
* create lock tracking on the red door
* create return-to-hub flow from each park
* create visual feedback for completed parks or unlocked locks
* create basic objective text if needed
* create the final interaction condition for the red door

**Deliverables:**

* playable hub scene
* five park entrances visible
* red door present and tracking progression
* placeholder park return flow working

**Why this phase matters:**
This phase creates the project's spine. Once it works, the rest becomes modular.

---

### Phase 3: Shared Systems Layer

**Goal:** Build reusable systems that multiple parks will need.

**Main tasks:**

* local checkpoint or retry support
* section completion handling
* key reward handling
* section start and end triggers
* basic dialogue framework for NPC interactions
* simple popup message system
* enemy health and damage foundation
* player health and damage foundation
* simple fail/success screen logic if needed
* scene or section reset logic

**Deliverables:**

* reusable core systems for park-specific gameplay
* basic framework for rewards, resets, and progression

**Why this phase matters:**
This reduces duplication and keeps park implementation cleaner.

---

### Phase 4: Medieval Park

**Goal:** Complete the first full park slice using horse traversal and melee combat.

**Main tasks:**

* build the Medieval Park scene layout
* create valley start area
* place castle destination ahead
* place return door behind player
* use mountains or blockers to limit side exploration
* implement horse interaction on **E**
* implement simple horse riding for forward traversal
* block horse entry into the return door
* build castle main hall combat arena
* place princess in cage
* place sword pickup on the floor
* implement sword pickup logic
* implement knight enemies
* implement melee combat rules for this park
* create respawn-before-fight logic if player dies
* trigger princess reward interaction after victory
* award Medieval key

**Deliverables:**

* fully playable Medieval Park
* first collectible key
* first end-to-end vertical slice from hub to completion and back

**Why this phase matters:**
This is the first proof that the game structure works in real gameplay.

---

### Phase 5: Pirates Park

**Goal:** Build a compact wave-defense gameplay slice.

**Main tasks:**

* build two connected ship areas
* create the narrow plank between ships
* place player cannon
* implement cannon aiming
* implement cannon firing
* implement reload delay
* implement pirate rush behavior along the plank
* implement wave or total-attacker completion condition
* allow player to board second ship after victory
* place and award Pirate key

**Deliverables:**

* fully playable Pirates Park
* second collectible key

**Why this phase matters:**
This park is compact and mechanically different. It adds variety without huge systemic cost.

---

### Phase 6: Olympus Park

**Goal:** Build the memory puzzle park.

**Main tasks:**

* build mountain or stair path
* design symbol tile system
* create visible sequence display at the top
* implement timed display of the sequence
* hide the sequence after a few seconds
* validate player tile steps against the correct order
* reset puzzle with a new sequence on failure
* track three successful rounds
* place and award Olympus key at the summit

**Deliverables:**

* fully playable Olympus Park
* third collectible key

**Why this phase matters:**
This adds a non-combat challenge and broadens the portfolio value.

---

### Phase 7: Dinosaurs Park

**Goal:** Build the stealth and chase park.

**Main tasks:**

* build the dinosaur field layout
* create tall grass hiding zones
* implement dinosaur patrol behavior
* implement detection rules for visible vs hidden player states
* create the first stealth traversal section
* implement frog pickup or frog resource system
* implement frog throwing or directional distraction logic
* implement dinosaur distraction response
* create the second stealth traversal section
* trigger the chase sequence near the end
* implement rapid-tap **W** chase event
* create waterfall cliff escape
* place and award Dinosaur key at the waterfall bottom

**Deliverables:**

* fully playable Dinosaurs Park
* fourth collectible key

**Why this phase matters:**
This is one of the most distinct parks and demonstrates stealth logic, patrol behavior, and sequence escalation.

---

### Phase 8: Wild West Park

**Goal:** Build the most dialogue-heavy and logic-heavy park.

**Main tasks:**

* build saloon interior
* build outdoor duel spot
* place bartender, sheriff, and suspect NPCs
* implement bartender guidance flow
* implement sheriff mission setup dialogue
* implement suspect dialogue structure
* create dialogue choices for each suspect
* create the duel accusation option
* implement transition from accusation to duel setup
* implement marked duel spot logic
* implement duel countdown
* implement gun draw on **E**
* implement duel timing and shot resolution
* define innocent vs killer outcome feedback
* create sheriff reward after correct killer is defeated
* award Wild West key

**Deliverables:**

* fully playable Wild West Park
* fifth collectible key

**Why this phase matters:**
This park is mechanically unique and likely the most complex in logic. It should come later, once the rest of the project is stable.

---

### Phase 9: Final Door and Ending Sequence

**Goal:** Complete the main progression arc and finish state.

**Main tasks:**

* ensure all five keys properly unlock all five locks
* implement final door interaction after all locks are opened
* create simple ending sequence
* show child waking up
* create end screen or credits screen

**Deliverables:**

* complete game loop from start to ending
* final payoff for project completion

**Why this phase matters:**
Without this, the game remains a collection of slices instead of a finished prototype.

---

### Phase 10: Polish and Portfolio Presentation

**Goal:** Improve readability, feedback, and overall presentation without expanding scope.

**Main tasks:**

* improve lighting in each park
* add clearer color identity per park
* improve UI readability
* add audio feedback for interactions, combat, success, and failure
* improve popups and objective messages
* add small visual effects where useful
* improve lock/key feedback on the red door
* tune transitions and pacing
* fix bugs and consistency issues

**Deliverables:**

* polished playable prototype
* portfolio-ready presentation state

**Why this phase matters:**
Polish is what turns a functional prototype into a portfolio piece.

---

## Recommended Build Order Rationale

The recommended order is:

1. Foundation
2. Hub and progression
3. Shared systems
4. Medieval
5. Pirates
6. Olympus
7. Dinosaurs
8. Wild West
9. Ending
10. Polish

This order is recommended because:

* Medieval proves core traversal + combat early
* Pirates is compact and easier to finish than stealth or dialogue systems
* Olympus adds puzzle variety with relatively controlled scope
* Dinosaurs comes after the project already has stronger structural support
* Wild West is saved for late production because it has the most dialogue and rule complexity

---

## Scope Discipline Rules During Production

To keep the project under control, use these rules throughout development:

* do not add extra parks
* do not expand one park into a large exploration area
* do not add advanced combat trees
* do not add unnecessary collectibles
* do not add large branching narrative outcomes
* do not replace placeholder art too early
* do not treat horse riding as a full vehicle system
* do not let Wild West dialogue scope explode
* prioritize completion over feature growth

---

## Milestone Strategy

A good milestone model for this project is:

* **Milestone 1:** third-person controller + hub + red door placeholder
* **Milestone 2:** first completed park with key flow working
* **Milestone 3:** three completed parks and visible progression on the red door
* **Milestone 4:** all five parks complete
* **Milestone 5:** full game loop complete with ending
* **Milestone 6:** polish and portfolio-ready build

---

## Final Summary

Dream Theme Park Prototype is a **small third-person 3D portfolio project** about escaping a dream by completing five themed park attractions and collecting five keys for a red escape door.

Its strength comes from combining:

* a memorable central concept
* strong section identity
* multiple gameplay styles
* prototype-friendly presentation
* tight scope boundaries

If kept small and polished, it can become a standout portfolio piece because it shows design range without losing a clear overall identity.

The development plan keeps the project structured around three truths:

* the game must stay small
* each park must stay focused on one main gameplay identity
* the whole project must remain stronger as a portfolio piece than it is large as a production

If built in this order, Dream Theme Park Prototype can become a polished third-person showcase project without overpowering the main Chief of Sin project.
