ZERO-LEGACY: UNITY DEMO


Spikemovement:
Het spike-systeem bestaat uit twee scripts die samen zorgen voor bewegende obstakels in de game. De SpikeSpawner spawnt om de paar seconden een spike op de positie van de spawner, waarbij de Y-positie telkens willekeurig wordt gekozen binnen een bepaalde range zodat de spikes niet altijd op dezelfde hoogte verschijnen. Elke gespawnede spike wordt na 30 seconden automatisch verwijderd om performance problemen te voorkomen. De MoveSpike zorgt er vervolgens voor dat elke spike constant naar links beweegt met een instelbare snelheid. Door deze combinatie ontstaan er continu nieuwe spikes die vanuit één kant het scherm in komen en richting de speler bewegen, wat zorgt voor een constante uitdaging.

Playermovement:
Het player movement systeem regelt de volledige besturing en het gedrag van de speler. De speler kan omhoog bewegen door Space, W of de pijltje-omhoog toets in te drukken, wat een opwaartse velocity geeft via een Rigidbody2D. Wanneer er geen input wordt gegeven, valt de speler automatisch naar beneden, waardoor er een constant “gravity gevoel” ontstaat. Met S of pijltje-omlaag kan de speler sneller naar beneden bewegen.
Daarnaast kan de speler versnellen naar rechts met D of pijltje-links, terwijl hij zonder input langzaam terug naar links beweegt tot een bepaalde limiet, waardoor de positionering gecontroleerd blijft.
De rotatie van de speler wordt dynamisch aangepast op basis van de verticale snelheid, waardoor het karakter kantelt tijdens het stijgen en dalen. Dit wordt soepel afgerond met een lerp zodat de beweging natuurlijk aanvoelt.
Wanneer de speler een object met de tag “spike” raakt, wordt de scene direct gewisseld naar een death-screen en wordt een gameplay status variabele aangepast.

Backgroundmovement:
Het achtergrond-systeem bestaat uit drie identieke sprites die samen een oneindige scrollende achtergrond vormen. Elk achtergronddeel beweegt continu naar links met een vaste snelheid, waardoor het lijkt alsof de speler vooruit beweegt in de wereld.
Wanneer een achtergrondstuk een bepaalde X-positie bereikt (uit beeld aan de linkerkant), wordt het direct verplaatst naar de rechterkant van het scherm. Hierdoor ontstaat een loop waarbij de drie stukken elkaar steeds opvolgen zonder dat er gaten of onderbrekingen zichtbaar zijn.
Door deze herpositionering in combinatie met constante beweging ontstaat een vloeiende en oneindige achtergrondscroll die de game dynamischer maakt zonder extra performance kosten.

Storytime:
Het “storytime” systeem wordt gebruikt om de voortgang van het spel te sturen over meerdere scenes heen. Dit wordt gedaan met een globale variabele (GameplayHandler.storytime) die elke seconde automatisch met 1 verhoogd wordt zolang het spel loopt. Deze waarde blijft bestaan tussen scenes door, waardoor de game een soort doorlopende tijdlijn krijgt.
Op basis van de waarde van storytime bepaalt het menu welke scene geladen moet worden wanneer de speler op start drukt. In het begin start de game bijvoorbeeld met een intro scene, daarna schakelt het tussen gameplay segments en story events op vaste momenten zoals 250, 500 en 750. Op die specifieke waarden worden speciale scenes geladen (zoals story-momenten of boss fights), en soms wordt de waarde direct verhoogd om te voorkomen dat dezelfde trigger opnieuw afgaat.