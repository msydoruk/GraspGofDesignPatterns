using StatePattern;

BosheOven bosheOven = new BosheOven();

bosheOven.IncreaseTemp(10);
bosheOven.Bake();
bosheOven.IncreaseTemp(50);
bosheOven.Bake();
bosheOven.Bake();
bosheOven.Bake();
bosheOven.IncreaseTemp(20);
bosheOven.Bake();
bosheOven.Bake();
bosheOven.Bake();
bosheOven.DecreaseTemp(30);
bosheOven.Bake();
bosheOven.Bake();
bosheOven.DecreaseTemp(40);
bosheOven.Bake();
bosheOven.Bake();