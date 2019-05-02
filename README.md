# DI

1. Brug NUGET til at tilføje en pakke `UNITY`
2. Lav en ny static klasse `IOC.cs`
3. I denne klasse skal der være et statisk felt `container` af typen `IUnityContainer`.
4. Lav en statisk konstruktør som sætter `container`til en ny instans af `UnityContainer`
5. Registrer typerne DataRepository, Datacontext og Notifie
```C#
container.RegisterType<DataRepository>();
container.RegisterType<DataContext>();
container.RegisterType<Notifier>();
```
6. I `Main()` erstattes `= new DataRepository();` med `IOC.container.Resolve<DataContext>();`
