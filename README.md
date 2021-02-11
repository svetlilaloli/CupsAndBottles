Console Application<br>
Exercise: Stacks and Queues
# CupsAndBottles
You will be given a __sequence of integers__ – each indicating a __cup's capacity__. After that you will be given __another sequence of integers__ – a __bottle with water__ in it. Your job is to try to __fill up__ all of the cups.<br><br>
Filling is done by picking __exactly one__ bottle at a time. You must start picking from __the last received bottle__ and start filling from __the first entered cup__. If the current bottle has __N__ water, you __give__ the __first entered cup N__ water and __reduce__ its integer value by __N__.<br><br>
When a cup's __integer value__ reaches __0 or less__, it __gets removed__. It is __possible__ that the current cup's value is __greater__ than the current bottle's value. __In that case__ you __pick bottles until__ you reduce the cup's integer value to __0 or less__. If a bottle's value is __greater or equal to__ the cup's __current__ value, you fill up the cup and __the remaining water becomes wasted__. You should __keep track of the wasted litters of water__ and __print it at the end of the program.__<br><br> 
If you __have managed__ to __fill up all of the cups__, print the __remaining water bottles__, from the __last entered – to the first__, otherwise you must print the __remaining cups__, by __order of entrance__ – from the __first entered – to the last__. 
## Input
- On the __first line__ of input you will receive the __integers__, representing the __cups' capacity__, __separated__ by a __single space__. 
-	On the __second line__ of input you will receive the __integers__, representing the __filled bottles__, __separated__ by a __single space__.
## Output
-	On the first line of output you must print the remaining bottles, or the remaining cups, depending on the case you are in. Just __keep__ the __orders of printing exactly as specified__. 
    - "__Bottles: {remainingBottles}__" or "__Cups: {remainingCups}__"
-	On the second line print the wasted litters of water in the following format: "__Wasted litters of water: {wastedLittersOfWater}__".
## Constraints
-	All of the given numbers will be valid integers in the range [1, 500].
-	It is safe to assume that there will be __NO__ case in which the water is __exactly as much__  as the cups' values, so that at the end there are no cups and no water in the bottles.
-	Allowed time/memory: 100ms/16MB.
## Examples
Input|Output|Comment
-----|------|-------
4 2 10 5<br>3 15 15 11 6|Bottles: 3<br>Wasted litters of water: 26|We take the first entered cup and the last entered bottle,<br> as it is described in the condition.<br> 6 – 4 = 2 – we have 2 more so the wasted water becomes 2.<br> 11 – 2 = 9 – again, it is more, so we add it to the previous amount,<br> which is 2 and it becomes 11.<br> 15 – 10 = 5 – wasted water becomes 16.<br> 15 – 5 = 10 – wasted water becomes 26.<br> We've managed to fill up all of the cups, so we print<br> the remaining bottles and the total amount of wasted water.
1 5 28 1 4<br>3 18 1 9 30 4 5|Cups: 4<br>Wasted litters of water: 35| 
10 20 30 40 50<br>20 11|Cups: 30 40 50<br>Wasted litters of water: 1| 
