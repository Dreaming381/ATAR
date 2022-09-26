# An Atypical Team With Atypical Responsibilities (ATAR) – Latios Framework Open Project \#2

This is the second open game project using Unity DOTS. It is used to develop and
validate new features and improvements in the Latios Framework, beginning with
version 0.6. A version of the framework is included as an embedded package.

The Unity version is currently 2021.3.8f1

Feel free to clone, play with, and customize this game however you like!

## Contributing

Contributions are very much welcome!

To contribute, fork the project. Make your changes, and make a pull request. Try
to avoid “merge commits” in your commit history.

If this is a game you can imagine yourself or a friend enjoying, and if you have
the skills or are willing to learn, get involved and help make the experience
better! The game will remain free and open source. There’s no revenue, and
anyone can be involved as much or as little as they want, for as short or as
long as they want.

## Concept, Gameplay, and Mechanics

ATAR, which stands for *an Atypical Team with Atypical Responsibilities* is a
combination of tower defense and first-person shooter where a team of magical
girls and their robot army defend castle towers in the sky. Gameplay alternates
between fortification and combat phases. If any magical girl dies, player or
not, it is game over.

Towers are indestructible. Resources for constructing towers are supplied at a
fixed rate for each wave cleared. There are different types of towers with
different accessories. Some have cover options, and some have special
interactions with specific magical girls.

Friendly robot sentries can be destroyed during the combat phase, but are
reconstructed at the beginning of a fortification phase at no cost. Resources
for constructing sentries are based on the enemies killed in a wave.

Magical girls can be recruited to help, but have specific requirements before
they can be recruited. Many require being provided a usable weapon, and some are
picky about the weapon. Other requirements include the number of waves already
defeated, or the existence of a specific type of tower. The UI for displaying
their requirements and abilities emulates a contact list on a cell phone.

During fortification, towers, sentries, and magical girls are all placed in
rectangular playing field in a top-down view. Sentries and magical girls must be
placed on towers.

Weapons require two parts to be usable. They require the weapon themselves, and
an Ammo Core that matches the weapon’s ammo type. Weapon drops from enemies are
fairly common. Ammo Core drops are rare. However, each wave guarantees at least
one matching pair of weapon and ammo core.

Ammo is unlimited. Though most magical girls will get tired if they throw too
many grenades in succession, causing the distance of the grenades to get short
enough to catch the thrower in the blast.

## Essential Technologies

In order for this game to reach a functional minimal viable product state, the
following technologies in the Latios Framework will need to be developed:

-   A robust character controller synchronized with animation
-   Advanced AI systems
-   Inverse Kinematics
-   Audio Mixing

## Future Technologies

The following features, while not strictly necessary, enhance the experience and
cover more future features of the Latios Framework

-   Storm Waves
    -   Clouds cover the playable area and are traversable, allowing magical
        girls and some sentry types to leave towers.
    -   Requires Psyshock terrain colliders
-   Death Ragdolls
    -   Requires Psyshock rigid-body physics simulation
-   Player Character Customization
    -   Requires validation of Kinemation runtime bindings and authoring
        workflow
-   Hair and Cloth Simulation
    -   Requires implementation
-   Character Intro Cutscenes
    -   Requires Kinemation Blend Shapes and Sequencing
-   More?

## Magical Girl Abilities

New ideas and suggestions are welcome. Any character without a name is open to
name suggestions.

### Player

An esper who can teleport between different towers and has enough medical
training to revive fallen magical girl friends if she reaches them in time.

### Experienced Esper

A fellow esper who is more practiced with the craft. Not only can she teleport,
but she can also apply a homing effect to nearby friendly projectiles. She
requires a gun but is otherwise immediately unlockable.

She has very pale skin, long dark curly hair, and speaks with a low voice. She
tends to be serious and straight-to-the-point with her words.

### Baseball Fanatic

She comes from a city named “Coudtop” which is home to the Stampede baseball
team. She requires a grenade type and grenade Ammo Core to be unlocked, but is
otherwise immediately unlockable. She always uses grenades as a primary weapon,
and will only resort to other weapons if she is low on health, sometimes. She
does not tire from throwing grenades.

She is loud and enthusiastic, and wears baseball attire.

### Clutch-Klutz

She has a reputation for being clumsy, but when things get serious she becomes a
focused killing machine. She requires a sniper to be unlocked, but is otherwise
immediately unlockable. When she or a nearby magical girl fall below a health
threshold, she quick-scope crits 100% of her shots.

She is normally social and sometimes bubbly, but when things are serious, she is
calm, collected, and tries to be encouraging.

### Ghost

She is dead and has low accuracy. She requires a gun, and cannot be unlocked
until several waves in as she is stuck in a Dead and Active Association (DA3)
meeting.

She is spunky and a little sassy, but loyal to the group and seeks personal
vengeance against the enemy.

### Witch

She is well-versed in medicinal witch craft and combat broom flight. She
requires a Witchcraft Bunker Tower to be unlocked. She can fly to low-health or
downed teammates, bring them to the nearest bunker, and revive them back to full
health. If given a weapon, she can also be destructive in her flights.

She tends to be very empathetic. Her witch outfit takes inspiration from medical
attire and symbolism.

## Third Party Notices

This project includes an embedded version of the Latios Framework which is
licensed under the Unity Companion License as a derivative work:
<https://github.com/Dreaming381/Latios-Framework/blob/master/LICENSE.md>
