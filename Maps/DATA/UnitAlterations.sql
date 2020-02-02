UPDATE UNIT
SET DaysToBuild = DaysToBuild * 1.4, Cost = Cost * 1.5
WHERE ClassNum = 0 AND MoveType > 0;

UPDATE UNIT
SET Cost = Cost * 1.75
WHERE ClassNum = 2;

UPDATE UNIT
SET Cost = Cost * 0.9
WHERE ClassNum = 3;

UPDATE UNIT
SET DaysToBuild = DaysToBuild * 1.5, Cost = Cost * 1.5
WHERE ClassNum = 4;

UPDATE UNIT
SET Cost = Cost * 2
WHERE ClassNum = 9;

UPDATE UNIT
SET Cost = Cost * 2.26
WHERE ClassNum = 10 OR ClassNum = 11;

UPDATE UNIT
SET DaysToBuild = DaysToBuild * 1.85, Cost = Cost * 3, CombatTime = CombatTime * 0.5
WHERE ClassNum = 12;

UPDATE UNIT
SET IGCost = IGCost * 0.25
WHERE [//SR5ID] = 21038 OR [//SR5ID] = 21037;

UPDATE UNIT
SET Pollution = Pollution * 2
WHERE Pollution IS NOT NULL;

UPDATE UNIT
SET DaysToBuild = DaysToBuild * 3, Cost = Cost * 2
WHERE [//SR5ID] = 21212 OR [//SR5ID] = 21211 OR [//SR5ID] = 21210 OR [//SR5ID] = 21213 OR [//SR5ID] = 21100;