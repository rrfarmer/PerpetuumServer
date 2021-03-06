namespace Perpetuum.Zones
{
    public enum ZoneCommand : byte
    {
        AuthUnit = 1,
        EnterUnit = 2,
        ExitUnit = 3,
        UpdateUnit = 4,
        Ping = 5,
        ServerPing = 6,
        ClientUpdate = 7,
        Beam = 8,
        // 9
        // 10
        // 11
        UpdateStat = 12,
        LockState = 13,
        LockTerrain = 14,
        // 15-16
        ModuleUseByCategoryFlag = 17,
        ModuleUse = 18,
        LockUnit = 19,
        LockPlant = 20,
        RemoveLock = 21,
        SetPrimaryLock = 22,
        ModuleChangeState = 23,
        ModuleEvaluateError = 24,
        LoadAmmo = 25,
        ReloadModulesByCategoryFlags = 26,
        // 27 - 28
        ClosingSocket = 29,
        // 30
        // 31
        CombatLog = 32,
        ScanUnitResult = 33,
        ScanContainerResult = 34,
        UnloadAmmo = 35,
        AmmoQty = 36,
        GetLootList = 37,
        LootList = 38,
        TakeLoot = 39,
        // 40
        ReleaseLoot = 41,
        AutoAmmoReload = 42,
        // 43
        GetModuleInfo = 44,
        ModuleInfoResult = 45,
        LayerUpdate = 46,
        GetLayer = 47,
        SetLayer = 48,
        ScanMaterialResult = 49,
        ScanOneTileResult = 50,
        GangUpdate = 51,
        //52
        CreateFieldContainer = 53,
        PutLoot = 54,
        Weather = 55,
        FieldContainerPin = 56,
        EnablePVP = 57,
        DeployItem = 58,
        Logout = 59,
        StartLogout = 60,
        CancelLogout = 61,
        GetUnitInfo = 62,
        UnitInfoResult = 63,

        Movement = 64,
        SetOrientation = 66,
        ControlCommand = 67,
        EffectOn = 68,
        EffectOff = 69,
        ScanArtifactResult = 70,
        ScanMineralAreaResult = 71,
        ScanMineralTileResult = 72,
        GangDoodle = 73,
        UseItem = 74,
        SAPInfo = 75,
        SAPPlayerInfo = 76,
        ScanIntrusionSiteResult = 77,
        ScanMineralDirectionalResult = 81,
        ConsumeItem = 82,
        ScanReinforceResult = 83,
        LocalChat = 84,
        LootContainerProgressInfo = 85,
        MoveForward = 86,
        Error,
        TerrainLockParameters = 88,
        GetTerrainLockParameters,
        SetTerrainLockParameters,
        GetMyRobotInfo,
        RobotInfo,
        RefreshUnit,
        ScanArtifactResult2,
    }
}