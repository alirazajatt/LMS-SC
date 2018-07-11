namespace LocationManagementSystem.CCFTCentralDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CCFTCentral : DbContext
    {
        public CCFTCentral()
            : base("name=CCFTCentral")
        {
            Database.SetInitializer<CCFTCentral>(null);
        }

        public virtual DbSet<AccessDecisionTileConfig> AccessDecisionTileConfigs { get; set; }
        public virtual DbSet<AccessTriplet> AccessTriplets { get; set; }
        public virtual DbSet<AccessZone> AccessZones { get; set; }
        public virtual DbSet<AccessZoneRelation> AccessZoneRelations { get; set; }
        public virtual DbSet<ActionPlan> ActionPlans { get; set; }
        public virtual DbSet<ActionPlanState> ActionPlanStates { get; set; }
        public virtual DbSet<AlarmDetailsTileField> AlarmDetailsTileFields { get; set; }
        public virtual DbSet<AlarmDialler> AlarmDiallers { get; set; }
        public virtual DbSet<AlarmInstruction> AlarmInstructions { get; set; }
        public virtual DbSet<AlarmInstructionAlarmNote> AlarmInstructionAlarmNotes { get; set; }
        public virtual DbSet<AlarmKeypad> AlarmKeypads { get; set; }
        public virtual DbSet<AlarmListConfig> AlarmListConfigs { get; set; }
        public virtual DbSet<AlarmListItemReference> AlarmListItemReferences { get; set; }
        public virtual DbSet<AlarmListNavPanelDisplayColumn> AlarmListNavPanelDisplayColumns { get; set; }
        public virtual DbSet<AlarmListNavPanelRule> AlarmListNavPanelRules { get; set; }
        public virtual DbSet<AlarmNote> AlarmNotes { get; set; }
        public virtual DbSet<AlarmPriority> AlarmPriorities { get; set; }
        public virtual DbSet<AlarmReceiver> AlarmReceivers { get; set; }
        public virtual DbSet<AlarmTransmitter> AlarmTransmitters { get; set; }
        public virtual DbSet<AlarmZone> AlarmZones { get; set; }
        public virtual DbSet<AlarmZoneRelation> AlarmZoneRelations { get; set; }
        public virtual DbSet<AperioDoor> AperioDoors { get; set; }
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<ArchiveFile> ArchiveFiles { get; set; }
        public virtual DbSet<ArchiveFileDivision> ArchiveFileDivisions { get; set; }
        public virtual DbSet<AustcoIntercom> AustcoIntercoms { get; set; }
        public virtual DbSet<AustcoIntercomSystem> AustcoIntercomSystems { get; set; }
        public virtual DbSet<AustcoIntercomViewerConfig> AustcoIntercomViewerConfigs { get; set; }
        public virtual DbSet<AustcoIntercomViewerConfigIntercom> AustcoIntercomViewerConfigIntercoms { get; set; }
        public virtual DbSet<AustcoIntercomViewerConfigPanelIntercom> AustcoIntercomViewerConfigPanelIntercoms { get; set; }
        public virtual DbSet<Bert> Berts { get; set; }
        public virtual DbSet<BertConnection> BertConnections { get; set; }
        public virtual DbSet<BertDatabase> BertDatabases { get; set; }
        public virtual DbSet<BertDN> BertDNS { get; set; }
        public virtual DbSet<BiometricReader> BiometricReaders { get; set; }
        public virtual DbSet<BulkChange> BulkChanges { get; set; }
        public virtual DbSet<BulkChangeCardholderAdvanced> BulkChangeCardholderAdvanceds { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Cardholder> Cardholders { get; set; }
        public virtual DbSet<CardholderCardsTileConfig> CardholderCardsTileConfigs { get; set; }
        public virtual DbSet<CardholderCompetencyPair> CardholderCompetencyPairs { get; set; }
        public virtual DbSet<CardholderDetailsTile> CardholderDetailsTiles { get; set; }
        public virtual DbSet<CardholderDetailsTileField> CardholderDetailsTileFields { get; set; }
        public virtual DbSet<CardholderFingerprint> CardholderFingerprints { get; set; }
        public virtual DbSet<CardholderFingerprintsTile> CardholderFingerprintsTiles { get; set; }
        public virtual DbSet<CardholderImagesTile> CardholderImagesTiles { get; set; }
        public virtual DbSet<CardholderInductionMaterialRead> CardholderInductionMaterialReads { get; set; }
        public virtual DbSet<CardholderLastSuccessfulAccess> CardholderLastSuccessfulAccesses { get; set; }
        public virtual DbSet<CardholderLocation> CardholderLocations { get; set; }
        public virtual DbSet<CardholderNotificationFilter> CardholderNotificationFilters { get; set; }
        public virtual DbSet<CardholderRole> CardholderRoles { get; set; }
        public virtual DbSet<CardholderSearchNavPanelDisplayColumn> CardholderSearchNavPanelDisplayColumns { get; set; }
        public virtual DbSet<CardLayout> CardLayouts { get; set; }
        public virtual DbSet<CardLayoutASCIIDESFire> CardLayoutASCIIDESFires { get; set; }
        public virtual DbSet<CardLayoutASCIIMifare> CardLayoutASCIIMifares { get; set; }
        public virtual DbSet<CardLayoutASCIIMifarePlu> CardLayoutASCIIMifarePlus { get; set; }
        public virtual DbSet<CardLayoutBarcode> CardLayoutBarcodes { get; set; }
        public virtual DbSet<CardLayoutGenericDESFire> CardLayoutGenericDESFires { get; set; }
        public virtual DbSet<CardLayoutGraphic> CardLayoutGraphics { get; set; }
        public virtual DbSet<CardLayoutMagstripe> CardLayoutMagstripes { get; set; }
        public virtual DbSet<CardLayoutMifare> CardLayoutMifares { get; set; }
        public virtual DbSet<CardLayoutMifarePlu> CardLayoutMifarePlus { get; set; }
        public virtual DbSet<CardLayoutObject> CardLayoutObjects { get; set; }
        public virtual DbSet<CardLayoutObjectElement> CardLayoutObjectElements { get; set; }
        public virtual DbSet<CardLayoutSagem> CardLayoutSagems { get; set; }
        public virtual DbSet<CardLayoutSagemDESFire> CardLayoutSagemDESFires { get; set; }
        public virtual DbSet<CardLayoutSalto> CardLayoutSaltoes { get; set; }
        public virtual DbSet<CardLayoutSide> CardLayoutSides { get; set; }
        public virtual DbSet<CardLayoutText> CardLayoutTexts { get; set; }
        public virtual DbSet<CardNumberFormat> CardNumberFormats { get; set; }
        public virtual DbSet<CardState> CardStates { get; set; }
        public virtual DbSet<CardStateNextState> CardStateNextStates { get; set; }
        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<CardWorkflow> CardWorkflows { get; set; }
        public virtual DbSet<CarParkGroup> CarParkGroups { get; set; }
        public virtual DbSet<ChangeSet> ChangeSets { get; set; }
        public virtual DbSet<ChangeSetField> ChangeSetFields { get; set; }
        public virtual DbSet<ChangeSetItem> ChangeSetItems { get; set; }
        public virtual DbSet<ChangeSetPending> ChangeSetPendings { get; set; }
        public virtual DbSet<ChangeSetRelation> ChangeSetRelations { get; set; }
        public virtual DbSet<Class5ELM> Class5ELM { get; set; }
        public virtual DbSet<ClientCertificateIssuer> ClientCertificateIssuers { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<ClubAlarmZone> ClubAlarmZones { get; set; }
        public virtual DbSet<ClubMembershipPair> ClubMembershipPairs { get; set; }
        public virtual DbSet<ClubPersonalDataFieldPair> ClubPersonalDataFieldPairs { get; set; }
        public virtual DbSet<Competency> Competencies { get; set; }
        public virtual DbSet<ComplexType> ComplexTypes { get; set; }
        public virtual DbSet<ComplexTypeProperty> ComplexTypeProperties { get; set; }
        public virtual DbSet<ConfigDispatchFieldControllerItemTypePair> ConfigDispatchFieldControllerItemTypePairs { get; set; }
        public virtual DbSet<ConfigDispatchRoute> ConfigDispatchRoutes { get; set; }
        public virtual DbSet<ControlledChallengeViewerConfig> ControlledChallengeViewerConfigs { get; set; }
        public virtual DbSet<ControlledChallengeViewerConfigPanelDoor> ControlledChallengeViewerConfigPanelDoors { get; set; }
        public virtual DbSet<ControllerItem> ControllerItems { get; set; }
        public virtual DbSet<ControllerItemCustomisation> ControllerItemCustomisations { get; set; }
        public virtual DbSet<ControllerItemType> ControllerItemTypes { get; set; }
        public virtual DbSet<ControllerPart> ControllerParts { get; set; }
        public virtual DbSet<CredentialInvitation> CredentialInvitations { get; set; }
        public virtual DbSet<CustomField> CustomFields { get; set; }
        public virtual DbSet<CycleDay> CycleDays { get; set; }
        public virtual DbSet<DatabaseSynchroniserPair> DatabaseSynchroniserPairs { get; set; }
        public virtual DbSet<DataMap> DataMaps { get; set; }
        public virtual DbSet<DataMapTuple> DataMapTuples { get; set; }
        public virtual DbSet<DataType> DataTypes { get; set; }
        public virtual DbSet<DayCategory> DayCategories { get; set; }
        public virtual DbSet<DefaultOperatorPreference> DefaultOperatorPreferences { get; set; }
        public virtual DbSet<DefinedEOLResistance> DefinedEOLResistances { get; set; }
        public virtual DbSet<DefinedEOLResistanceThreshold> DefinedEOLResistanceThresholds { get; set; }
        public virtual DbSet<DetectedDevice> DetectedDevices { get; set; }
        public virtual DbSet<DeviceSoftware> DeviceSoftwares { get; set; }
        public virtual DbSet<DeviceSoftwareModule> DeviceSoftwareModules { get; set; }
        public virtual DbSet<DisturbanceSensor> DisturbanceSensors { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<DivisionBadgeText> DivisionBadgeTexts { get; set; }
        public virtual DbSet<DivisionDescendant> DivisionDescendants { get; set; }
        public virtual DbSet<DivisionFindVisitorGridColumn> DivisionFindVisitorGridColumns { get; set; }
        public virtual DbSet<DivisionHomePageField> DivisionHomePageFields { get; set; }
        public virtual DbSet<DivisionInductionMaterial> DivisionInductionMaterials { get; set; }
        public virtual DbSet<DivisionInductionMaterialAnswer> DivisionInductionMaterialAnswers { get; set; }
        public virtual DbSet<DivisionInductionMaterialGroup> DivisionInductionMaterialGroups { get; set; }
        public virtual DbSet<DivisionInductionMaterialGroupVideo> DivisionInductionMaterialGroupVideos { get; set; }
        public virtual DbSet<DivisionInductionMaterialQuestion> DivisionInductionMaterialQuestions { get; set; }
        public virtual DbSet<DivisionKioskHostField> DivisionKioskHostFields { get; set; }
        public virtual DbSet<DivisionKioskMessage> DivisionKioskMessages { get; set; }
        public virtual DbSet<DivisionMacro> DivisionMacroes { get; set; }
        public virtual DbSet<DivisionVisitAction> DivisionVisitActions { get; set; }
        public virtual DbSet<DivisionVisitorType> DivisionVisitorTypes { get; set; }
        public virtual DbSet<DivisionVisitorTypeAccessGroup> DivisionVisitorTypeAccessGroups { get; set; }
        public virtual DbSet<DivisionVisitorTypeBusinessCardScannerField> DivisionVisitorTypeBusinessCardScannerFields { get; set; }
        public virtual DbSet<DivisionVisitorTypeField> DivisionVisitorTypeFields { get; set; }
        public virtual DbSet<DivisionVisitorTypeHostType> DivisionVisitorTypeHostTypes { get; set; }
        public virtual DbSet<DivisionVisitorTypeVisitVisitorField> DivisionVisitorTypeVisitVisitorFields { get; set; }
        public virtual DbSet<Door> Doors { get; set; }
        public virtual DbSet<DoorLastAccess> DoorLastAccesses { get; set; }
        public virtual DbSet<DoorPersonalDataFieldPair> DoorPersonalDataFieldPairs { get; set; }
        public virtual DbSet<DoorRelation> DoorRelations { get; set; }
        public virtual DbSet<DVRCamera> DVRCameras { get; set; }
        public virtual DbSet<DVRCameraTileConfig> DVRCameraTileConfigs { get; set; }
        public virtual DbSet<DVRType> DVRTypes { get; set; }
        public virtual DbSet<ElmoMessageBatch> ElmoMessageBatches { get; set; }
        public virtual DbSet<ElmoPersonalDataFieldPair> ElmoPersonalDataFieldPairs { get; set; }
        public virtual DbSet<EnrolmentTemplate> EnrolmentTemplates { get; set; }
        public virtual DbSet<ErnieTypeMap> ErnieTypeMaps { get; set; }
        public virtual DbSet<EventGroup> EventGroups { get; set; }
        public virtual DbSet<EventGroupDefaultInstruction> EventGroupDefaultInstructions { get; set; }
        public virtual DbSet<EventGroupItemActionPlan> EventGroupItemActionPlans { get; set; }
        public virtual DbSet<EventGroupItemAlarmInstruction> EventGroupItemAlarmInstructions { get; set; }
        public virtual DbSet<EventGroupZoneActionPlan> EventGroupZoneActionPlans { get; set; }
        public virtual DbSet<EventTrailTile> EventTrailTiles { get; set; }
        public virtual DbSet<EventTrailTileItem> EventTrailTileItems { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<EventTypeDefaultInstruction> EventTypeDefaultInstructions { get; set; }
        public virtual DbSet<EventTypeItemAlarmInstruction> EventTypeItemAlarmInstructions { get; set; }
        public virtual DbSet<ExpiryNotificationRecord> ExpiryNotificationRecords { get; set; }
        public virtual DbSet<ExternalEventSource> ExternalEventSources { get; set; }
        public virtual DbSet<ExternalSystem> ExternalSystems { get; set; }
        public virtual DbSet<ExternalSystemType> ExternalSystemTypes { get; set; }
        public virtual DbSet<FacilityCode> FacilityCodes { get; set; }
        public virtual DbSet<FenceController> FenceControllers { get; set; }
        public virtual DbSet<FenceZone> FenceZones { get; set; }
        public virtual DbSet<FidoAuthenticator> FidoAuthenticators { get; set; }
        public virtual DbSet<FidoCredential> FidoCredentials { get; set; }
        public virtual DbSet<FieldDevice> FieldDevices { get; set; }
        public virtual DbSet<FieldDeviceSoftware> FieldDeviceSoftwares { get; set; }
        public virtual DbSet<FingerprintBiometricType> FingerprintBiometricTypes { get; set; }
        public virtual DbSet<Frazzle> Frazzles { get; set; }
        public virtual DbSet<FTItem> FTItems { get; set; }
        public virtual DbSet<FTItemType> FTItemTypes { get; set; }
        public virtual DbSet<FTItemTypeState> FTItemTypeStates { get; set; }
        public virtual DbSet<GBusURI> GBusURIs { get; set; }
        public virtual DbSet<GuardTour> GuardTours { get; set; }
        public virtual DbSet<GuardTourCheckpoint> GuardTourCheckpoints { get; set; }
        public virtual DbSet<GuardTourProgress> GuardTourProgresses { get; set; }
        public virtual DbSet<GuardTourTileConfig> GuardTourTileConfigs { get; set; }
        public virtual DbSet<GuardTourTileConfigItem> GuardTourTileConfigItems { get; set; }
        public virtual DbSet<HBUSAlarmsTerminal> HBUSAlarmsTerminals { get; set; }
        public virtual DbSet<HBUSDevice> HBUSDevices { get; set; }
        public virtual DbSet<HBUSIOBoard> HBUSIOBoards { get; set; }
        public virtual DbSet<HBUSReader> HBUSReaders { get; set; }
        public virtual DbSet<HBUSTautWireSensor> HBUSTautWireSensors { get; set; }
        public virtual DbSet<HBUSTerminalAlarmZonePair> HBUSTerminalAlarmZonePairs { get; set; }
        public virtual DbSet<HBUSTerminalFenceControllerPair> HBUSTerminalFenceControllerPairs { get; set; }
        public virtual DbSet<HBUSTerminalIdleImage> HBUSTerminalIdleImages { get; set; }
        public virtual DbSet<HBUSTerminalMimicItem> HBUSTerminalMimicItems { get; set; }
        public virtual DbSet<HBUSTerminalOutputPair> HBUSTerminalOutputPairs { get; set; }
        public virtual DbSet<HBUSTerminal> HBUSTerminals { get; set; }
        public virtual DbSet<IconSet> IconSets { get; set; }
        public virtual DbSet<IconSetStateSetting> IconSetStateSettings { get; set; }
        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<InsertionTag> InsertionTags { get; set; }
        public virtual DbSet<IntercomSystem> IntercomSystems { get; set; }
        public virtual DbSet<InterlockDoor> InterlockDoors { get; set; }
        public virtual DbSet<InterlockException> InterlockExceptions { get; set; }
        public virtual DbSet<InterlockSetting> InterlockSettings { get; set; }
        public virtual DbSet<ISIntercom> ISIntercoms { get; set; }
        public virtual DbSet<JacquesIntercomViewerConfig> JacquesIntercomViewerConfigs { get; set; }
        public virtual DbSet<JacquesIntercomViewerConfigPanelIntercom> JacquesIntercomViewerConfigPanelIntercoms { get; set; }
        public virtual DbSet<KeyMap> KeyMaps { get; set; }
        public virtual DbSet<LicensingGroup> LicensingGroups { get; set; }
        public virtual DbSet<LicensingGroupLimit> LicensingGroupLimits { get; set; }
        public virtual DbSet<LiftCar> LiftCars { get; set; }
        public virtual DbSet<LiftCarLevel> LiftCarLevels { get; set; }
        public virtual DbSet<LiftCarRelation> LiftCarRelations { get; set; }
        public virtual DbSet<LiftHLI> LiftHLIs { get; set; }
        public virtual DbSet<LiftHLIProtocol> LiftHLIProtocols { get; set; }
        public virtual DbSet<LogicBlock> LogicBlocks { get; set; }
        public virtual DbSet<LogicBlockRelation> LogicBlockRelations { get; set; }
        public virtual DbSet<LogicBlockRule> LogicBlockRules { get; set; }
        public virtual DbSet<Macro> Macroes { get; set; }
        public virtual DbSet<MacroAction> MacroActions { get; set; }
        public virtual DbSet<MacroCommandLine> MacroCommandLines { get; set; }
        public virtual DbSet<MacroRepeatingSchedule> MacroRepeatingSchedules { get; set; }
        public virtual DbSet<MacroSchedule> MacroSchedules { get; set; }
        public virtual DbSet<MailUserAgent> MailUserAgents { get; set; }
        public virtual DbSet<MessageAdapterPair> MessageAdapterPairs { get; set; }
        public virtual DbSet<MimicPointLedResponse> MimicPointLedResponses { get; set; }
        public virtual DbSet<MiscellaneousIcon> MiscellaneousIcons { get; set; }
        public virtual DbSet<MobileDevice> MobileDevices { get; set; }
        public virtual DbSet<MobileDeviceCardholderSearchPDF> MobileDeviceCardholderSearchPDFs { get; set; }
        public virtual DbSet<MobileDeviceCardholderSearchType> MobileDeviceCardholderSearchTypes { get; set; }
        public virtual DbSet<MobileDeviceChallengeReason> MobileDeviceChallengeReasons { get; set; }
        public virtual DbSet<MobileDeviceEnrolment> MobileDeviceEnrolments { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NotificationFilter> NotificationFilters { get; set; }
        public virtual DbSet<OPCDataBranch> OPCDataBranches { get; set; }
        public virtual DbSet<OPCDataField> OPCDataFields { get; set; }
        public virtual DbSet<OPCDataVerb> OPCDataVerbs { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<OperatorClub> OperatorClubs { get; set; }
        public virtual DbSet<OperatorClubDivision> OperatorClubDivisions { get; set; }
        public virtual DbSet<OperatorClubMembershipPair> OperatorClubMembershipPairs { get; set; }
        public virtual DbSet<OperatorClubPDFAccessPair> OperatorClubPDFAccessPairs { get; set; }
        public virtual DbSet<OperatorClubPrivilegePair> OperatorClubPrivilegePairs { get; set; }
        public virtual DbSet<OperatorClubWorkstationPair> OperatorClubWorkstationPairs { get; set; }
        public virtual DbSet<OperatorPrivilege> OperatorPrivileges { get; set; }
        public virtual DbSet<OperatorSession> OperatorSessions { get; set; }
        public virtual DbSet<OSDPDevice> OSDPDevices { get; set; }
        public virtual DbSet<Output> Outputs { get; set; }
        public virtual DbSet<PersonalDataDate> PersonalDataDates { get; set; }
        public virtual DbSet<PersonalDataField> PersonalDataFields { get; set; }
        public virtual DbSet<PersonalDataImageID> PersonalDataImageIDs { get; set; }
        public virtual DbSet<PersonalDataInteger> PersonalDataIntegers { get; set; }
        public virtual DbSet<PersonalDataString> PersonalDataStrings { get; set; }
        public virtual DbSet<PersonalisedAction> PersonalisedActions { get; set; }
        public virtual DbSet<PivCard> PivCards { get; set; }
        public virtual DbSet<PivCardCertValidationSetting> PivCardCertValidationSettings { get; set; }
        public virtual DbSet<PivCardIssuerCertificate> PivCardIssuerCertificates { get; set; }
        public virtual DbSet<PivCardIssuingCA> PivCardIssuingCAs { get; set; }
        public virtual DbSet<PivCardIssuingCAMap> PivCardIssuingCAMaps { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<RelationshipInfo> RelationshipInfoes { get; set; }
        public virtual DbSet<RemoteElmo> RemoteElmoes { get; set; }
        public virtual DbSet<RemoteFTItemField> RemoteFTItemFields { get; set; }
        public virtual DbSet<RemoteOverrideCancelFlag> RemoteOverrideCancelFlags { get; set; }
        public virtual DbSet<RemoteOverrideInfo> RemoteOverrideInfoes { get; set; }
        public virtual DbSet<RemoteOverrideVerbInfo> RemoteOverrideVerbInfoes { get; set; }
        public virtual DbSet<ReportDefinition> ReportDefinitions { get; set; }
        public virtual DbSet<ReportDefinitionItem> ReportDefinitionItems { get; set; }
        public virtual DbSet<ReportDefinitionSchedule> ReportDefinitionSchedules { get; set; }
        public virtual DbSet<ReportDefinitionScheduleTime> ReportDefinitionScheduleTimes { get; set; }
        public virtual DbSet<ReportDescription> ReportDescriptions { get; set; }
        public virtual DbSet<ReportScheduleTime> ReportScheduleTimes { get; set; }
        public virtual DbSet<RequiredPrivilege> RequiredPrivileges { get; set; }
        public virtual DbSet<ReservedCardNumber> ReservedCardNumbers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SADPlugin> SADPlugins { get; set; }
        public virtual DbSet<SaltoAccessTriplet> SaltoAccessTriplets { get; set; }
        public virtual DbSet<SaltoCard> SaltoCards { get; set; }
        public virtual DbSet<SaltoServer> SaltoServers { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ScheduleEntry> ScheduleEntries { get; set; }
        public virtual DbSet<SchindlerIDSystem> SchindlerIDSystems { get; set; }
        public virtual DbSet<SchlageDevice> SchlageDevices { get; set; }
        public virtual DbSet<SessionBookmark> SessionBookmarks { get; set; }
        public virtual DbSet<SessionOperatorAccess> SessionOperatorAccesses { get; set; }
        public virtual DbSet<SessionOperatorClub> SessionOperatorClubs { get; set; }
        public virtual DbSet<SessionOperatorRouting> SessionOperatorRoutings { get; set; }
        public virtual DbSet<SessionPermission> SessionPermissions { get; set; }
        public virtual DbSet<SessionSubscription> SessionSubscriptions { get; set; }
        public virtual DbSet<SessionSubscriptionItem> SessionSubscriptionItems { get; set; }
        public virtual DbSet<SharedBinary> SharedBinaries { get; set; }
        public virtual DbSet<SharedText> SharedTexts { get; set; }
        public virtual DbSet<SiteItem> SiteItems { get; set; }
        public virtual DbSet<SiteItemCameraPair> SiteItemCameraPairs { get; set; }
        public virtual DbSet<SitePlan> SitePlans { get; set; }
        public virtual DbSet<SitePlanGraphic> SitePlanGraphics { get; set; }
        public virtual DbSet<SitePlanGraphicItem> SitePlanGraphicItems { get; set; }
        public virtual DbSet<SitePlanGraphicPoint> SitePlanGraphicPoints { get; set; }
        public virtual DbSet<SitePlanLink> SitePlanLinks { get; set; }
        public virtual DbSet<SitePlanTileConfig> SitePlanTileConfigs { get; set; }
        public virtual DbSet<SoftwareProcess> SoftwareProcesses { get; set; }
        public virtual DbSet<SpecialDay> SpecialDays { get; set; }
        public virtual DbSet<SpotMonitorViewer> SpotMonitorViewers { get; set; }
        public virtual DbSet<SpotMonitorViewerRule> SpotMonitorViewerRules { get; set; }
        public virtual DbSet<SpotMonitorViewerRuleDivisionItemType> SpotMonitorViewerRuleDivisionItemTypes { get; set; }
        public virtual DbSet<SpringType> SpringTypes { get; set; }
        public virtual DbSet<StatusTile> StatusTiles { get; set; }
        public virtual DbSet<StatusTileItem> StatusTileItems { get; set; }
        public virtual DbSet<SupportedLanguage> SupportedLanguages { get; set; }
        public virtual DbSet<TagboardFTItem> TagboardFTItems { get; set; }
        public virtual DbSet<TagBoardTile> TagBoardTiles { get; set; }
        public virtual DbSet<TautWireGroup> TautWireGroups { get; set; }
        public virtual DbSet<TautWireSensor> TautWireSensors { get; set; }
        public virtual DbSet<Timeout> Timeouts { get; set; }
        public virtual DbSet<UniversalCardFormat> UniversalCardFormats { get; set; }
        public virtual DbSet<UnnamedItemType> UnnamedItemTypes { get; set; }
        public virtual DbSet<UrlTile> UrlTiles { get; set; }
        public virtual DbSet<Viewer> Viewers { get; set; }
        public virtual DbSet<ViewerOperatorGroupPair> ViewerOperatorGroupPairs { get; set; }
        public virtual DbSet<ViewerPanel> ViewerPanels { get; set; }
        public virtual DbSet<ViewerPanelTile> ViewerPanelTiles { get; set; }
        public virtual DbSet<ViewerPanelTileItemRelationship> ViewerPanelTileItemRelationships { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<VisitSegment> VisitSegments { get; set; }
        public virtual DbSet<VisitVisitor> VisitVisitors { get; set; }
        public virtual DbSet<VisitVisitorAccessGroup> VisitVisitorAccessGroups { get; set; }
        public virtual DbSet<VisitVisitorAction> VisitVisitorActions { get; set; }
        public virtual DbSet<VisitVisitorNotificationLog> VisitVisitorNotificationLogs { get; set; }
        public virtual DbSet<VisitVisitorStatusChanx> VisitVisitorStatusChanges { get; set; }
        public virtual DbSet<WireType> WireTypes { get; set; }
        public virtual DbSet<Wizard> Wizards { get; set; }
        public virtual DbSet<WizardTemplate> WizardTemplates { get; set; }
        public virtual DbSet<Workstation> Workstations { get; set; }
        public virtual DbSet<WorkstationBase> WorkstationBases { get; set; }
        public virtual DbSet<WorkstationRouting> WorkstationRoutings { get; set; }
        public virtual DbSet<WorkstationRoutingLinkedItem> WorkstationRoutingLinkedItems { get; set; }
        public virtual DbSet<WorkstationRoutingOperatorClub> WorkstationRoutingOperatorClubs { get; set; }
        public virtual DbSet<WorkstationRoutingWorkstation> WorkstationRoutingWorkstations { get; set; }
        public virtual DbSet<AccessZoneCompetencyPair> AccessZoneCompetencyPairs { get; set; }
        public virtual DbSet<ActionPlanOutput> ActionPlanOutputs { get; set; }
        public virtual DbSet<ActionPlanTrigger> ActionPlanTriggers { get; set; }
        public virtual DbSet<APITriggerTag> APITriggerTags { get; set; }
        public virtual DbSet<BackupSet> BackupSets { get; set; }
        public virtual DbSet<BertDependent> BertDependents { get; set; }
        public virtual DbSet<BulkChangeCardholderPurge> BulkChangeCardholderPurges { get; set; }
        public virtual DbSet<BulkChangeMod> BulkChangeMods { get; set; }
        public virtual DbSet<CardHistory> CardHistories { get; set; }
        public virtual DbSet<ChildParentHBusDevice> ChildParentHBusDevices { get; set; }
        public virtual DbSet<CompetencyMessageInfo> CompetencyMessageInfoes { get; set; }
        public virtual DbSet<Customisation> Customisations { get; set; }
        public virtual DbSet<DBTemplateRestoreHook> DBTemplateRestoreHooks { get; set; }
        public virtual DbSet<EDIConfigData> EDIConfigDatas { get; set; }
        public virtual DbSet<EDIConfiguration> EDIConfigurations { get; set; }
        public virtual DbSet<ElmoMessage> ElmoMessages { get; set; }
        public virtual DbSet<EnrolmentTemplateData> EnrolmentTemplateDatas { get; set; }
        public virtual DbSet<FTItemRelationship> FTItemRelationships { get; set; }
        public virtual DbSet<Licence> Licences { get; set; }
        public virtual DbSet<MobileDeviceDefault> MobileDeviceDefaults { get; set; }
        public virtual DbSet<OperatorClubCompetencyAccessPair> OperatorClubCompetencyAccessPairs { get; set; }
        public virtual DbSet<OperatorExpiredPassword> OperatorExpiredPasswords { get; set; }
        public virtual DbSet<OperatorPreference> OperatorPreferences { get; set; }
        public virtual DbSet<OperatorSiteRestriction> OperatorSiteRestrictions { get; set; }
        public virtual DbSet<Override> Overrides { get; set; }
        public virtual DbSet<PersonalDataStrList> PersonalDataStrLists { get; set; }
        public virtual DbSet<PhotoIDPrintingEventReason> PhotoIDPrintingEventReasons { get; set; }
        public virtual DbSet<PivCardCertPolicy> PivCardCertPolicies { get; set; }
        public virtual DbSet<PivCardTrustedRootCert> PivCardTrustedRootCerts { get; set; }
        public virtual DbSet<PromptEntry> PromptEntries { get; set; }
        public virtual DbSet<ReflectIOPair> ReflectIOPairs { get; set; }
        public virtual DbSet<ReportDefinitionEmailRecipient> ReportDefinitionEmailRecipients { get; set; }
        public virtual DbSet<SingleValue> SingleValues { get; set; }
        public virtual DbSet<SiteDefaultStateName> SiteDefaultStateNames { get; set; }
        public virtual DbSet<SiteNotifyPDF> SiteNotifyPDFs { get; set; }
        public virtual DbSet<ViewerItemRelationship> ViewerItemRelationships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.AccessZone1)
                .WithOptional(e => e.AccessZone2)
                .HasForeignKey(e => e.ParentZoneID);

            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.AccessZoneCompetencyPairs)
                .WithRequired(e => e.AccessZone)
                .HasForeignKey(e => e.AccessZoneID);

            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.AperioDoors)
                .WithOptional(e => e.AccessZone)
                .HasForeignKey(e => e.EntryZoneID);

            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.LiftCarLevels)
                .WithOptional(e => e.AccessZone)
                .HasForeignKey(e => e.AccessZoneID);

            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.Overrides)
                .WithRequired(e => e.AccessZone)
                .HasForeignKey(e => e.AccessZoneID);

            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.PersonalisedActions)
                .WithRequired(e => e.AccessZone)
                .HasForeignKey(e => e.AccessZoneID);

            modelBuilder.Entity<AccessZone>()
                .HasMany(e => e.Doors)
                .WithMany(e => e.AccessZones)
                .Map(m => m.ToTable("AccessZoneExitDoors").MapLeftKey("AccessZoneID").MapRightKey("ExitDoorID"));

            modelBuilder.Entity<ActionPlan>()
                .HasMany(e => e.ActionPlanOutputs)
                .WithRequired(e => e.ActionPlan)
                .HasForeignKey(e => e.ActionPlanID);

            modelBuilder.Entity<ActionPlan>()
                .HasMany(e => e.ActionPlanStates)
                .WithRequired(e => e.ActionPlan)
                .HasForeignKey(e => e.ActionPlanID);

            modelBuilder.Entity<ActionPlan>()
                .HasMany(e => e.ActionPlanTriggers)
                .WithRequired(e => e.ActionPlan)
                .HasForeignKey(e => e.ActionPlanID);

            modelBuilder.Entity<ActionPlan>()
                .HasMany(e => e.EventGroups)
                .WithRequired(e => e.ActionPlan)
                .HasForeignKey(e => e.DefaultActionPlanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActionPlan>()
                .HasMany(e => e.EventGroupItemActionPlans)
                .WithRequired(e => e.ActionPlan)
                .HasForeignKey(e => e.ActionPlanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActionPlan>()
                .HasMany(e => e.EventGroupZoneActionPlans)
                .WithRequired(e => e.ActionPlan)
                .HasForeignKey(e => e.ActionPlanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmDetailsTileField>()
                .Property(e => e.BrowseName)
                .IsUnicode(false);

            modelBuilder.Entity<AlarmInstruction>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<AlarmInstruction>()
                .HasMany(e => e.AlarmInstructionAlarmNotes)
                .WithRequired(e => e.AlarmInstruction)
                .HasForeignKey(e => e.AlarmInstructionID);

            modelBuilder.Entity<AlarmInstruction>()
                .HasMany(e => e.EventGroupDefaultInstructions)
                .WithRequired(e => e.AlarmInstruction)
                .HasForeignKey(e => e.AlarmInstructionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmInstruction>()
                .HasMany(e => e.EventGroupItemAlarmInstructions)
                .WithRequired(e => e.AlarmInstruction)
                .HasForeignKey(e => e.AlarmInstructionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmInstruction>()
                .HasMany(e => e.EventTypeDefaultInstructions)
                .WithRequired(e => e.AlarmInstruction)
                .HasForeignKey(e => e.AlarmInstructionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmInstruction>()
                .HasMany(e => e.EventTypeItemAlarmInstructions)
                .WithRequired(e => e.AlarmInstruction)
                .HasForeignKey(e => e.AlarmInstructionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmInstruction>()
                .HasMany(e => e.InsertionTags)
                .WithMany(e => e.AlarmInstructions)
                .Map(m => m.ToTable("AlarmInstructionTag").MapLeftKey("AlarmInstructionID").MapRightKey("InsertionTagID"));

            modelBuilder.Entity<AlarmKeypad>()
                .HasMany(e => e.FTItems)
                .WithMany(e => e.AlarmKeypads)
                .Map(m => m.ToTable("AlarmKeypadAlarmZone").MapLeftKey("AlarmKeypadID").MapRightKey("AlarmZoneID"));

            modelBuilder.Entity<AlarmKeypad>()
                .HasMany(e => e.FTItems1)
                .WithMany(e => e.AlarmKeypads1)
                .Map(m => m.ToTable("AlarmKeypadFenceZone").MapLeftKey("AlarmKeypadID").MapRightKey("FenceZoneID"));

            modelBuilder.Entity<AlarmKeypad>()
                .HasMany(e => e.Inputs)
                .WithMany(e => e.AlarmKeypads)
                .Map(m => m.ToTable("AlarmKeypadInput").MapLeftKey("AlarmKeypadID").MapRightKey("InputID"));

            modelBuilder.Entity<AlarmTransmitter>()
                .HasMany(e => e.AlarmReceivers)
                .WithRequired(e => e.AlarmTransmitter)
                .HasForeignKey(e => e.AlarmTransmitterID);

            modelBuilder.Entity<AlarmZone>()
                .HasMany(e => e.AlarmListNavPanelRules)
                .WithOptional(e => e.AlarmZone)
                .HasForeignKey(e => e.AlarmZoneID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<AlarmZone>()
                .HasMany(e => e.AlarmZoneRelations)
                .WithRequired(e => e.AlarmZone)
                .HasForeignKey(e => e.AlarmZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmZone>()
                .HasMany(e => e.AlarmZoneRelations1)
                .WithRequired(e => e.AlarmZone1)
                .HasForeignKey(e => e.AlarmZoneID);

            modelBuilder.Entity<AlarmZone>()
                .HasMany(e => e.EventGroupZoneActionPlans)
                .WithRequired(e => e.AlarmZone)
                .HasForeignKey(e => e.AlarmZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmZone>()
                .HasMany(e => e.HBUSTerminalAlarmZonePairs)
                .WithRequired(e => e.AlarmZone)
                .HasForeignKey(e => e.AlarmZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlarmZone>()
                .HasMany(e => e.SiteItems)
                .WithOptional(e => e.AlarmZone1)
                .HasForeignKey(e => e.AlarmZoneID);

            modelBuilder.Entity<Archive>()
                .Property(e => e.EncryptedAccountPassword)
                .IsFixedLength();

            modelBuilder.Entity<ArchiveFile>()
                .Property(e => e.Digest)
                .IsFixedLength();

            modelBuilder.Entity<AustcoIntercomSystem>()
                .Property(e => e.HostName)
                .IsUnicode(false);

            modelBuilder.Entity<Bert>()
                .Property(e => e.CurrentDLLs)
                .IsUnicode(false);

            modelBuilder.Entity<Bert>()
                .HasMany(e => e.BertDependents)
                .WithOptional(e => e.Bert)
                .HasForeignKey(e => e.BertID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Bert>()
                .HasMany(e => e.BertDNS)
                .WithRequired(e => e.Bert)
                .HasForeignKey(e => e.BertId);

            modelBuilder.Entity<Bert>()
                .HasMany(e => e.InterlockSettings)
                .WithOptional(e => e.Bert)
                .HasForeignKey(e => e.BertID);

            modelBuilder.Entity<Bert>()
                .HasMany(e => e.FTItems)
                .WithMany(e => e.Berts)
                .Map(m => m.ToTable("BertCardFormats").MapLeftKey("BertID").MapRightKey("CardFormatID"));

            modelBuilder.Entity<BulkChange>()
                .HasMany(e => e.BulkChangeMods)
                .WithRequired(e => e.BulkChange)
                .HasForeignKey(e => e.BulkChangeID);

            modelBuilder.Entity<BulkChange>()
                .HasMany(e => e.FTItems)
                .WithMany(e => e.BulkChanges)
                .Map(m => m.ToTable("BulkChangeItems").MapLeftKey("BulkChangeID").MapRightKey("FTItemID"));

            modelBuilder.Entity<Calendar>()
                .HasMany(e => e.CycleDays)
                .WithRequired(e => e.Calendar)
                .HasForeignKey(e => e.CalendarID);

            modelBuilder.Entity<Calendar>()
                .HasMany(e => e.SpecialDays)
                .WithRequired(e => e.Calendar)
                .HasForeignKey(e => e.CalendarID);

            modelBuilder.Entity<Card>()
                .HasMany(e => e.CredentialInvitations)
                .WithRequired(e => e.Card)
                .HasForeignKey(e => e.CardID);

            modelBuilder.Entity<Card>()
                .HasMany(e => e.FidoCredentials)
                .WithRequired(e => e.Card)
                .HasForeignKey(e => e.CardID);

            modelBuilder.Entity<Card>()
                .HasOptional(e => e.PivCard)
                .WithRequired(e => e.Card)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Cardholder>()
                .Property(e => e.EncryptedUserCode)
                .IsFixedLength();

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.Cards)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.CardholderCompetencyPairs)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.CardholderInductionMaterialReads)
                .WithRequired(e => e.Cardholder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.CardholderNotificationFilters)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.CardholderRoles)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.CardholderRoles1)
                .WithRequired(e => e.Cardholder1)
                .HasForeignKey(e => e.RoleCardholderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.ClubMembershipPairs)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.OperatorClubMembershipPairs)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.OperatorID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.OperatorExpiredPasswords)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.OperatorID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.OperatorPreferences)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.OperatorID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.PersonalDataDates)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.PersonalDataImageIDs)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.PersonalDataIntegers)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.PersonalDataStrings)
                .WithRequired(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID);

            modelBuilder.Entity<Cardholder>()
                .HasMany(e => e.ReportDefinitionEmailRecipients)
                .WithOptional(e => e.Cardholder)
                .HasForeignKey(e => e.CardholderID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardholderDetailsTileField>()
                .Property(e => e.BrowseName)
                .IsUnicode(false);

            modelBuilder.Entity<CardholderSearchNavPanelDisplayColumn>()
                .Property(e => e.FieldBrowseName)
                .IsUnicode(false);

            modelBuilder.Entity<CardLayout>()
                .Property(e => e.MifareEncodingType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CardLayoutASCIIMifare>()
                .Property(e => e.ReadKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutASCIIMifare>()
                .Property(e => e.WriteKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutASCIIMifarePlu>()
                .Property(e => e.ReadKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutASCIIMifarePlu>()
                .Property(e => e.WriteKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutASCIIMifarePlu>()
                .Property(e => e.ReadKeyPlus)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutASCIIMifarePlu>()
                .Property(e => e.WriteKeyPlus)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutMifare>()
                .Property(e => e.SectorKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutMifarePlu>()
                .Property(e => e.SectorKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutObject>()
                .Property(e => e.ObjectType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutASCIIDESFire)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutASCIIMifare)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutASCIIMifarePlu)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutBarcode)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutGenericDESFire)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutGraphic)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutMagstripe)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutMifare)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutMifarePlu)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasMany(e => e.CardLayoutObjectElements)
                .WithRequired(e => e.CardLayoutObject)
                .HasForeignKey(e => new { e.FTItemID, e.SideIndex, e.ObjectIndex });

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutSagem)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutSagemDESFire)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutSalto)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutObject>()
                .HasOptional(e => e.CardLayoutText)
                .WithRequired(e => e.CardLayoutObject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardLayoutSagem>()
                .Property(e => e.SectorKey)
                .IsFixedLength();

            modelBuilder.Entity<CardLayoutSide>()
                .HasMany(e => e.CardLayoutObjects)
                .WithRequired(e => e.CardLayoutSide)
                .HasForeignKey(e => new { e.FTItemID, e.SideIndex });

            modelBuilder.Entity<CardState>()
                .HasMany(e => e.CardStateNextStates)
                .WithRequired(e => e.CardState)
                .HasForeignKey(e => new { e.CardWorkflowID, e.FromStateID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CardState>()
                .HasMany(e => e.CardStateNextStates1)
                .WithRequired(e => e.CardState1)
                .HasForeignKey(e => new { e.CardWorkflowID, e.ToStateID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CardState>()
                .HasMany(e => e.CardWorkflows)
                .WithOptional(e => e.CardState)
                .HasForeignKey(e => new { e.FTItemID, e.InitialCardState });

            modelBuilder.Entity<CardType>()
                .HasMany(e => e.AperioDoors)
                .WithOptional(e => e.CardType)
                .HasForeignKey(e => e.CardTypeID);

            modelBuilder.Entity<CardType>()
                .HasMany(e => e.Cards)
                .WithRequired(e => e.CardType)
                .HasForeignKey(e => e.CardTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CardType>()
                .HasOptional(e => e.CardLayout)
                .WithRequired(e => e.CardType)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardType>()
                .HasMany(e => e.EnrolmentTemplates)
                .WithOptional(e => e.CardType)
                .HasForeignKey(e => e.CardTypeID);

            modelBuilder.Entity<CardType>()
                .HasOptional(e => e.PivCardCertValidationSetting)
                .WithRequired(e => e.CardType)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CardWorkflow>()
                .HasMany(e => e.CardStates)
                .WithRequired(e => e.CardWorkflow)
                .HasForeignKey(e => e.CardWorkflowID);

            modelBuilder.Entity<CardWorkflow>()
                .HasMany(e => e.CardTypes)
                .WithOptional(e => e.CardWorkflow)
                .HasForeignKey(e => e.CardWorkflowID);

            modelBuilder.Entity<ChangeSet>()
                .HasOptional(e => e.ChangeSetPending)
                .WithRequired(e => e.ChangeSet)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ChangeSetPending>()
                .Property(e => e.Result)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.AccessTriplets)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.ClubID);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Club1)
                .WithOptional(e => e.Club2)
                .HasForeignKey(e => e.ParentClubID);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.ClubMembershipPairs)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.ClubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.ClubPersonalDataFieldPairs)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.ClubID);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.SaltoAccessTriplets)
                .WithRequired(e => e.Club)
                .HasForeignKey(e => e.ClubID);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Club11)
                .WithMany(e => e.Clubs)
                .Map(m => m.ToTable("ClubAncestor").MapLeftKey("AncestorID").MapRightKey("ClubID"));

            modelBuilder.Entity<Competency>()
                .HasMany(e => e.CardholderCompetencyPairs)
                .WithRequired(e => e.Competency)
                .HasForeignKey(e => e.CompetencyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Competency>()
                .HasMany(e => e.AccessZoneCompetencyPairs)
                .WithRequired(e => e.Competency)
                .HasForeignKey(e => e.CompetencyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Competency>()
                .HasMany(e => e.CompetencyMessageInfoes)
                .WithOptional(e => e.Competency)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Competency>()
                .HasMany(e => e.OperatorClubCompetencyAccessPairs)
                .WithRequired(e => e.Competency)
                .HasForeignKey(e => e.CompetencyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Competency>()
                .HasMany(e => e.DivisionInductionMaterials)
                .WithMany(e => e.Competencies)
                .Map(m => m.ToTable("DivisionInductionMaterialCompetency").MapLeftKey("CompetencyID").MapRightKey(new[] { "FTItemID", "InductionMaterialID" }));

            modelBuilder.Entity<ControllerItemType>()
                .HasMany(e => e.ConfigDispatchFieldControllerItemTypePairs)
                .WithRequired(e => e.ControllerItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControllerItemType>()
                .HasMany(e => e.ConfigDispatchRoutes)
                .WithRequired(e => e.ControllerItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DataType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DataType>()
                .HasOptional(e => e.ComplexType)
                .WithRequired(e => e.DataType)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DataType>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.DataType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DayCategory>()
                .HasMany(e => e.CycleDays)
                .WithRequired(e => e.DayCategory)
                .HasForeignKey(e => e.DayCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DayCategory>()
                .HasMany(e => e.ScheduleEntries)
                .WithRequired(e => e.DayCategory)
                .HasForeignKey(e => e.DayCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DayCategory>()
                .HasMany(e => e.SpecialDays)
                .WithRequired(e => e.DayCategory)
                .HasForeignKey(e => e.DayCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DefaultOperatorPreference>()
                .Property(e => e.StateData)
                .IsFixedLength();

            modelBuilder.Entity<DefinedEOLResistance>()
                .HasMany(e => e.DefinedEOLResistanceThresholds)
                .WithRequired(e => e.DefinedEOLResistance)
                .HasForeignKey(e => e.EOLSchemeID);

            modelBuilder.Entity<DetectedDevice>()
                .Property(e => e.DeviceSerial)
                .IsFixedLength();

            modelBuilder.Entity<DeviceSoftware>()
                .HasMany(e => e.DeviceSoftwareModules)
                .WithRequired(e => e.DeviceSoftware)
                .HasForeignKey(e => e.DeviceSoftwareID);

            modelBuilder.Entity<DeviceSoftware>()
                .HasMany(e => e.FieldDeviceSoftwares)
                .WithOptional(e => e.DeviceSoftware)
                .HasForeignKey(e => e.DeviceSoftwareID);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.CardholderInductionMaterialReads)
                .WithRequired(e => e.Division)
                .HasForeignKey(e => e.DivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Division1)
                .WithOptional(e => e.Division2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.DivisionDescendants)
                .WithRequired(e => e.Division)
                .HasForeignKey(e => e.DescendantID);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.DivisionDescendants1)
                .WithRequired(e => e.Division1)
                .HasForeignKey(e => e.DivisionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.OperatorClubDivisions)
                .WithRequired(e => e.Division)
                .HasForeignKey(e => e.DivisionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.OperatorSessions)
                .WithOptional(e => e.Division)
                .HasForeignKey(e => e.CurrentDivisionID);

            modelBuilder.Entity<DivisionInductionMaterial>()
                .HasMany(e => e.DivisionInductionMaterialQuestions)
                .WithRequired(e => e.DivisionInductionMaterial)
                .HasForeignKey(e => new { e.FTItemID, e.InductionMaterialID });

            modelBuilder.Entity<DivisionInductionMaterialGroup>()
                .HasMany(e => e.DivisionInductionMaterialGroupVideos)
                .WithRequired(e => e.DivisionInductionMaterialGroup)
                .HasForeignKey(e => new { e.FTItemID, e.InductionMaterialGroupID });

            modelBuilder.Entity<DivisionInductionMaterialQuestion>()
                .HasMany(e => e.DivisionInductionMaterialAnswers)
                .WithRequired(e => e.DivisionInductionMaterialQuestion)
                .HasForeignKey(e => new { e.FTItemID, e.InductionMaterialID, e.InductionMaterialQuestionID });

            modelBuilder.Entity<DivisionVisitorType>()
                .HasMany(e => e.DivisionVisitorTypeAccessGroups)
                .WithRequired(e => e.DivisionVisitorType)
                .HasForeignKey(e => new { e.FTItemID, e.VisitorTypeID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DivisionVisitorType>()
                .HasMany(e => e.DivisionVisitorTypeBusinessCardScannerFields)
                .WithRequired(e => e.DivisionVisitorType)
                .HasForeignKey(e => new { e.FTItemID, e.VisitorTypeID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DivisionVisitorType>()
                .HasMany(e => e.DivisionVisitorTypeFields)
                .WithRequired(e => e.DivisionVisitorType)
                .HasForeignKey(e => new { e.FTItemID, e.VisitorTypeID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DivisionVisitorType>()
                .HasMany(e => e.DivisionVisitorTypeHostTypes)
                .WithRequired(e => e.DivisionVisitorType)
                .HasForeignKey(e => new { e.FTItemID, e.VisitorTypeID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DivisionVisitorType>()
                .HasMany(e => e.DivisionVisitorTypeVisitVisitorFields)
                .WithRequired(e => e.DivisionVisitorType)
                .HasForeignKey(e => new { e.FTItemID, e.VisitorTypeID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Door>()
                .HasMany(e => e.ControlledChallengeViewerConfigPanelDoors)
                .WithRequired(e => e.Door)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Door>()
                .HasMany(e => e.DoorPersonalDataFieldPairs)
                .WithRequired(e => e.Door)
                .HasForeignKey(e => e.DoorID);

            modelBuilder.Entity<Door>()
                .HasMany(e => e.DoorRelations)
                .WithRequired(e => e.Door)
                .HasForeignKey(e => e.DoorID);

            modelBuilder.Entity<Door>()
                .HasMany(e => e.Viewers)
                .WithMany(e => e.Doors)
                .Map(m => m.ToTable("ControlledChallengeViewerConfigDoor").MapLeftKey("DoorFTItemID").MapRightKey("FTItemID"));

            modelBuilder.Entity<DVRCamera>()
                .HasMany(e => e.SiteItemCameraPairs)
                .WithRequired(e => e.DVRCamera)
                .HasForeignKey(e => e.CameraID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnrolmentTemplate>()
                .HasMany(e => e.EnrolmentTemplateDatas)
                .WithRequired(e => e.EnrolmentTemplate)
                .HasForeignKey(e => e.EnrolmentTemplateID);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventGroupDefaultInstructions)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventGroupItemActionPlans)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventGroupItemAlarmInstructions)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventGroupZoneActionPlans)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventTypes)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.NotificationFilters)
                .WithMany(e => e.EventGroups)
                .Map(m => m.ToTable("NotificationFilterEventGroup").MapLeftKey("EventGroupID").MapRightKey(new[] { "NotificationFilterID", "OverridingTypeID" }));

            modelBuilder.Entity<EventType>()
                .HasMany(e => e.EventTypeDefaultInstructions)
                .WithRequired(e => e.EventType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventType>()
                .HasMany(e => e.EventTypeItemAlarmInstructions)
                .WithRequired(e => e.EventType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventType>()
                .HasMany(e => e.FTItemTypes)
                .WithMany(e => e.EventTypes)
                .Map(m => m.ToTable("ItemTypeEventTypePair").MapLeftKey("EventTypeID").MapRightKey("FTItemTypeID"));

            modelBuilder.Entity<EventType>()
                .HasMany(e => e.NotificationFilters)
                .WithMany(e => e.EventTypes)
                .Map(m => m.ToTable("NotificationFilterEventType").MapLeftKey("EventTypeID").MapRightKey(new[] { "NotificationFilterID", "OverridingTypeID" }));

            modelBuilder.Entity<ExternalSystem>()
                .HasMany(e => e.ExternalSystem1)
                .WithOptional(e => e.ExternalSystem2)
                .HasForeignKey(e => e.IdentitySameAs);

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.AperioDoor)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.DisturbanceSensor)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.ExternalEventSource)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.ExternalSystem)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasMany(e => e.ActionPlanOutputs)
                .WithRequired(e => e.FieldDevice)
                .HasForeignKey(e => e.OutputID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FieldDevice>()
                .HasMany(e => e.FieldDeviceSoftwares)
                .WithRequired(e => e.FieldDevice)
                .HasForeignKey(e => e.FieldDeviceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.Input)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.LiftHLI)
                .WithRequired(e => e.FieldDevice);

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.OSDPDevice)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.Output)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasMany(e => e.ReflectIOPairs)
                .WithOptional(e => e.FieldDevice)
                .HasForeignKey(e => e.OutputID);

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.SchlageDevice)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FieldDevice>()
                .HasOptional(e => e.TautWireSensor)
                .WithRequired(e => e.FieldDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Frazzle>()
                .HasMany(e => e.HBUSTerminalFenceControllerPairs)
                .WithRequired(e => e.Frazzle)
                .HasForeignKey(e => e.FenceControllerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.AccessDecisionTileConfigs)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.SpecificDoorItemID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.AccessTriplets)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ScheduleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.AccessZoneRelations)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.AccessZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.AccessZoneRelations1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.RelatedItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.ActionPlan)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.AlarmInstruction)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.AlarmListItemReferences)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ReferencedFTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.AlarmTransmitter)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.AlarmZoneRelations)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.RelatedItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Archive)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.BulkChange)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.BulkChangeCardholderAdvanced)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Calendar)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Cardholders)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.VisitorResponsibilityID);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Cardholder)
                .WithRequired(e => e.FTItem1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.CardholderLastSuccessfulAccess)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.CardholderLocation)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.CardType)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.CardWorkflow)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Club)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ClubAlarmZones)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.AccessGroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Competency)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.DataMap)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.DayCategory)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DetectedDevices)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ControllerID);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.DeviceSoftware)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.CardTypeID);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Division)
                .WithRequired(e => e.FTItem1)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions1)
                .WithOptional(e => e.FTItem2)
                .HasForeignKey(e => e.KioskAdministratorGroupID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions2)
                .WithOptional(e => e.FTItem3)
                .HasForeignKey(e => e.KioskRapidVisitorGroupID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions3)
                .WithOptional(e => e.FTItem4)
                .HasForeignKey(e => e.KioskSuperHostGroupID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions4)
                .WithOptional(e => e.FTItem5)
                .HasForeignKey(e => e.KioskVisitorSearchPDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions5)
                .WithOptional(e => e.FTItem6)
                .HasForeignKey(e => e.KioskVisitorTypeID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Divisions6)
                .WithOptional(e => e.FTItem7)
                .HasForeignKey(e => e.VisitorDivisionID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionBadgeTexts)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionFindVisitorGridColumns)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionFindVisitorGridColumns1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionHomePageFields)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionHomePageFields1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionKioskHostFields)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionKioskHostFields1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionMacroes)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionMacroes1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.MacroID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitActions)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypes)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.CardTypeID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypes1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypes2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.VisitorTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeAccessGroups)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.AccessGroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeAccessGroups1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeAccessGroups2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.VisitorTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeBusinessCardScannerFields)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeBusinessCardScannerFields1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeBusinessCardScannerFields2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.VisitorTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeFields)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeFields1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeFields2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.VisitorTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeHostTypes)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeHostTypes1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.HostTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeHostTypes2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.VisitorTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeVisitVisitorFields)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeVisitVisitorFields1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DivisionVisitorTypeVisitVisitorFields2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.VisitorTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DoorLastAccesses)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.DoorID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DoorPersonalDataFieldPairs)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.PersonalDataFieldID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.DoorRelations)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.RelatedItemID);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.DVRCamera)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.DVRType)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.ElmoPersonalDataFieldPair)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.EnrolmentTemplate)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.EventGroups)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.DefaultAlarmInstructionID);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.FingerprintBiometricType)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ActionPlanTriggers)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.BertDependent)
                .WithRequired(e => e.FTItem);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.FTItemRelationships)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.DependentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.FTItemRelationships1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.ItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.GuardTours)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.ClubID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.GuardTours1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.GuardID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.GuardTourCheckpoints)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.DoorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.GuardTourProgresses)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.DoorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.IconSet)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.InsertionTag)
                .WithRequired(e => e.FTItem);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.IntercomSystem)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.InterlockDoors)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.DoorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.InterlockExceptions)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.Door1ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.InterlockExceptions1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.Door2ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.ISIntercom)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.LicensingGroup)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.LiftCarLevels)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.LiftCarID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.LiftCarRelations)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.RelatedItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.LogicBlock)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.LogicBlockRelations)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.RelatedItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Macro)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.MacroActions)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ActionItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.MacroSchedules)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.OperatorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.MacroSchedules1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.WorkstationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.MacroSchedules2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.OperatorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.MacroSchedules3)
                .WithRequired(e => e.FTItem3)
                .HasForeignKey(e => e.WorkstationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Note)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.NotificationFilters)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.NotificationFilterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.NotificationFilters1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.OverridingTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Operator)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.OperatorClub)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.OperatorClubWorkstationPairs)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.OperatorClubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.OperatorClubWorkstationPairs1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.WorkstationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.OperatorPrivilege)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.PersonalDataField)
                .WithRequired(e => e.FTItem);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Reception)
                .WithRequired(e => e.FTItem);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.ReportDefinition)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ReportDefinitionItems)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ReferencedFTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.ReportDescription)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ReportScheduleTimes)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ReportDescriptionID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ReservedCardNumbers)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.CardholderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ReservedCardNumbers1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.CardTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Role)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.SaltoAccessTriplets)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.ScheduleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Schedule)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.SessionOperatorClubs)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.OperatorClubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.SiteItem)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.SiteItems)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.ScheduleID);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.SitePlan)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.UniversalCardFormat)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Viewer)
                .WithRequired(e => e.FTItem);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ViewerItemRelationships)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.DependentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.ViewerItemRelationships1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.ItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.Visit)
                .WithRequired(e => e.FTItem);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Visits)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.PlannedReception);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Visits1)
                .WithOptional(e => e.FTItem2)
                .HasForeignKey(e => e.RegisteredBy);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Visits2)
                .WithOptional(e => e.FTItem3)
                .HasForeignKey(e => e.VisitorType);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitSegments)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.EscortID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitSegments1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitors)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.CardholderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitors1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.CardTypeID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitors2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorAccessGroups)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.AccessGroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorAccessGroups1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.CardholderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorAccessGroups2)
                .WithRequired(e => e.FTItem2)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorActions)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.CardholderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorActions1)
                .WithRequired(e => e.FTItem1)
                .HasForeignKey(e => e.FTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorNotificationLogs)
                .WithRequired(e => e.FTItem)
                .HasForeignKey(e => e.CardholderNotifiedID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.VisitVisitorStatusChanges)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.WizardTemplate)
                .WithRequired(e => e.FTItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Workstations)
                .WithOptional(e => e.FTItem)
                .HasForeignKey(e => e.AssignCardDoorId);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Workstations1)
                .WithOptional(e => e.FTItem1)
                .HasForeignKey(e => e.VMSDoorID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.Workstations2)
                .WithOptional(e => e.FTItem2)
                .HasForeignKey(e => e.VMSReceptionID);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.FTItem1)
                .WithMany(e => e.FTItems)
                .Map(m => m.ToTable("DivisionSearchVisitorDivision").MapLeftKey("FTItemID").MapRightKey("VisitorSearchDivisionID"));

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.NotificationFilters2)
                .WithMany(e => e.FTItems)
                .Map(m => m.ToTable("NotificationFilterEventSource").MapLeftKey("ItemID").MapRightKey(new[] { "NotificationFilterID", "OverridingTypeID" }));

            modelBuilder.Entity<FTItem>()
                .HasOptional(e => e.FTItem11)
                .WithMany(e => e.FTItems1);

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.SpotMonitorViewerRules)
                .WithMany(e => e.FTItems)
                .Map(m => m.ToTable("SpotMonitorViewerRuleEventSource").MapLeftKey("EventSourceID").MapRightKey(new[] { "FTItemID", "RuleID" }));

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.TagBoardTiles)
                .WithMany(e => e.FTItems)
                .Map(m => m.ToTable("TagBoardTileAccessZone").MapLeftKey("AccessZoneID").MapRightKey("TileID"));

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.FTItem12)
                .WithMany(e => e.FTItems2)
                .Map(m => m.ToTable("VisitAccessGroup").MapLeftKey("AccessGroupID").MapRightKey("FTItemID"));

            modelBuilder.Entity<FTItem>()
                .HasMany(e => e.WorkstationBases)
                .WithMany(e => e.FTItems)
                .Map(m => m.ToTable("WorkstationOperatorClubPair").MapLeftKey("OperatorClubID").MapRightKey("WorkstationID"));

            modelBuilder.Entity<FTItemType>()
                .HasMany(e => e.ConfigDispatchFieldControllerItemTypePairs)
                .WithRequired(e => e.FTItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItemType>()
                .HasMany(e => e.FTItems)
                .WithOptional(e => e.FTItemType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<FTItemType>()
                .HasMany(e => e.IconSets)
                .WithRequired(e => e.FTItemType)
                .HasForeignKey(e => e.FTItemTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItemType>()
                .HasMany(e => e.RemoteOverrideInfoes)
                .WithRequired(e => e.FTItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItemType>()
                .HasMany(e => e.RemoteOverrideVerbInfoes)
                .WithRequired(e => e.FTItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItemType>()
                .HasMany(e => e.UnnamedItemTypes)
                .WithRequired(e => e.FTItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FTItemType>()
                .HasOptional(e => e.RemoteOverrideCancelFlag)
                .WithRequired(e => e.FTItemType);

            modelBuilder.Entity<FTItemTypeState>()
                .HasMany(e => e.IconSetStateSettings)
                .WithRequired(e => e.FTItemTypeState)
                .HasForeignKey(e => new { e.FTItemTypeID, e.IconState })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GuardTour>()
                .HasMany(e => e.GuardTourCheckpoints)
                .WithRequired(e => e.GuardTour)
                .HasForeignKey(e => e.GuardTourID);

            modelBuilder.Entity<GuardTour>()
                .HasMany(e => e.GuardTourProgresses)
                .WithRequired(e => e.GuardTour)
                .HasForeignKey(e => e.GuardTourID);

            modelBuilder.Entity<HBUSDevice>()
                .HasMany(e => e.HBUSTautWireSensors)
                .WithRequired(e => e.HBUSDevice)
                .HasForeignKey(e => new { e.FTItemID, e.SerialNumber });

            modelBuilder.Entity<HBUSTerminal>()
                .HasMany(e => e.HBUSTerminalAlarmZonePairs)
                .WithRequired(e => e.HBUSTerminal)
                .HasForeignKey(e => e.HBUSTerminalID);

            modelBuilder.Entity<HBUSTerminal>()
                .HasMany(e => e.HBUSTerminalFenceControllerPairs)
                .WithRequired(e => e.HBUSTerminal)
                .HasForeignKey(e => e.HBUSTerminalID);

            modelBuilder.Entity<HBUSTerminal>()
                .HasMany(e => e.HBUSTerminalMimicItems)
                .WithRequired(e => e.HBUSTerminal)
                .HasForeignKey(e => e.HBUSTerminalID);

            modelBuilder.Entity<HBUSTerminal>()
                .HasMany(e => e.HBUSTerminalOutputPairs)
                .WithRequired(e => e.HBUSTerminal)
                .HasForeignKey(e => e.HBUSTerminalID);

            modelBuilder.Entity<HBUSTerminal>()
                .HasMany(e => e.Inputs)
                .WithMany(e => e.HBUSTerminals)
                .Map(m => m.ToTable("HBUSTerminalInput").MapLeftKey("HBUSTerminalID").MapRightKey("InputID"));

            modelBuilder.Entity<IconSet>()
                .HasMany(e => e.FTItemTypes)
                .WithOptional(e => e.IconSet)
                .HasForeignKey(e => e.DefaultIconSetID);

            modelBuilder.Entity<IconSet>()
                .HasMany(e => e.IconSetStateSettings)
                .WithRequired(e => e.IconSet)
                .HasForeignKey(e => e.IconSetID);

            modelBuilder.Entity<IconSet>()
                .HasMany(e => e.SiteItems)
                .WithOptional(e => e.IconSet)
                .HasForeignKey(e => e.IconSetID);

            modelBuilder.Entity<IconSet>()
                .HasMany(e => e.SitePlans)
                .WithOptional(e => e.IconSet)
                .HasForeignKey(e => e.IconSetID);

            modelBuilder.Entity<IconSet>()
                .HasMany(e => e.SitePlanLinks)
                .WithOptional(e => e.IconSet)
                .HasForeignKey(e => e.IconSetID);

            modelBuilder.Entity<IntercomSystem>()
                .HasMany(e => e.ISIntercoms)
                .WithRequired(e => e.IntercomSystem)
                .HasForeignKey(e => e.IntercomSystemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ISIntercom>()
                .HasMany(e => e.JacquesIntercomViewerConfigPanelIntercoms)
                .WithRequired(e => e.ISIntercom)
                .HasForeignKey(e => e.IntercomFTItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LiftCar>()
                .HasMany(e => e.LiftCarRelations)
                .WithRequired(e => e.LiftCar)
                .HasForeignKey(e => e.LiftCarID);

            modelBuilder.Entity<LiftHLI>()
                .Property(e => e.ConfigurationString)
                .IsUnicode(false);

            modelBuilder.Entity<LogicBlock>()
                .HasMany(e => e.LogicBlockRelations)
                .WithRequired(e => e.LogicBlock)
                .HasForeignKey(e => e.LogicBlockID);

            modelBuilder.Entity<LogicBlock>()
                .HasMany(e => e.LogicBlockRules)
                .WithRequired(e => e.LogicBlock)
                .HasForeignKey(e => e.LogicBlockID);

            modelBuilder.Entity<Macro>()
                .HasOptional(e => e.MacroRepeatingSchedule)
                .WithRequired(e => e.Macro)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Macro>()
                .HasMany(e => e.WorkstationRoutings)
                .WithOptional(e => e.Macro)
                .HasForeignKey(e => e.DisableMacroID);

            modelBuilder.Entity<Macro>()
                .HasMany(e => e.WorkstationRoutings1)
                .WithOptional(e => e.Macro1)
                .HasForeignKey(e => e.GroupAMacroID);

            modelBuilder.Entity<Macro>()
                .HasMany(e => e.WorkstationRoutings2)
                .WithOptional(e => e.Macro2)
                .HasForeignKey(e => e.GroupBMacroID);

            modelBuilder.Entity<MobileDevice>()
                .HasOptional(e => e.MobileDeviceEnrolment)
                .WithRequired(e => e.MobileDevice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Operator>()
                .Property(e => e.EncryptedPassword)
                .IsFixedLength();

            modelBuilder.Entity<Operator>()
                .HasMany(e => e.OperatorSessions)
                .WithRequired(e => e.Operator)
                .HasForeignKey(e => e.OperatorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.OperatorClubCompetencyAccessPairs)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorClubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.OperatorClubDivisions)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorClubID);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.OperatorClubMembershipPairs)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorClubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.OperatorClubPDFAccessPairs)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorClubID);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.OperatorClubPrivilegePairs)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorClubID);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.ViewerOperatorGroupPairs)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorGroupID);

            modelBuilder.Entity<OperatorClub>()
                .HasMany(e => e.WorkstationRoutingOperatorClubs)
                .WithRequired(e => e.OperatorClub)
                .HasForeignKey(e => e.OperatorClubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorPrivilege>()
                .HasMany(e => e.OperatorClubPrivilegePairs)
                .WithRequired(e => e.OperatorPrivilege)
                .HasForeignKey(e => e.PrivilegeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorPrivilege>()
                .HasMany(e => e.RequiredPrivileges)
                .WithRequired(e => e.OperatorPrivilege)
                .HasForeignKey(e => e.PrivilegeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorSession>()
                .Property(e => e.LastContactTime)
                .HasPrecision(0);

            modelBuilder.Entity<OperatorSession>()
                .Property(e => e.Token)
                .IsFixedLength();

            modelBuilder.Entity<OperatorSession>()
                .HasMany(e => e.SessionOperatorAccesses)
                .WithRequired(e => e.OperatorSession)
                .HasForeignKey(e => e.SessionID);

            modelBuilder.Entity<OperatorSession>()
                .HasMany(e => e.SessionOperatorClubs)
                .WithRequired(e => e.OperatorSession)
                .HasForeignKey(e => e.SessionID);

            modelBuilder.Entity<OperatorSession>()
                .HasMany(e => e.SessionOperatorRoutings)
                .WithRequired(e => e.OperatorSession)
                .HasForeignKey(e => e.SessionID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperatorSession>()
                .HasMany(e => e.SessionPermissions)
                .WithRequired(e => e.OperatorSession)
                .HasForeignKey(e => e.SessionID);

            modelBuilder.Entity<OperatorSession>()
                .HasMany(e => e.SessionSubscriptions)
                .WithRequired(e => e.OperatorSession)
                .HasForeignKey(e => e.SessionID);

            modelBuilder.Entity<Output>()
                .HasMany(e => e.HBUSTerminalOutputPairs)
                .WithRequired(e => e.Output)
                .HasForeignKey(e => e.OutputID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Output>()
                .HasMany(e => e.LiftCarLevels)
                .WithOptional(e => e.Output)
                .HasForeignKey(e => e.OutputID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.CardholderSearchNavPanelDisplayColumns)
                .WithOptional(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.ClubPersonalDataFieldPairs)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.EnrolmentTemplates)
                .WithOptional(e => e.PersonalDataField)
                .HasForeignKey(e => e.CardholderPDFID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.EnrolmentTemplates1)
                .WithOptional(e => e.PersonalDataField1)
                .HasForeignKey(e => e.OtherPDFID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.EnrolmentTemplates2)
                .WithOptional(e => e.PersonalDataField2)
                .HasForeignKey(e => e.PrimaryPDFID);

            modelBuilder.Entity<PersonalDataField>()
                .HasOptional(e => e.MobileDeviceCardholderSearchPDF)
                .WithRequired(e => e.PersonalDataField);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.OperatorClubPDFAccessPairs)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.PersonalDataDates)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.EnrolmentTemplateDatas)
                .WithOptional(e => e.PersonalDataField)
                .HasForeignKey(e => e.PDFID);

            modelBuilder.Entity<PersonalDataField>()
                .HasOptional(e => e.SiteNotifyPDF)
                .WithRequired(e => e.PersonalDataField)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.PersonalDataImageIDs)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.PersonalDataIntegers)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.PersonalDataStrings)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID);

            modelBuilder.Entity<PersonalDataField>()
                .HasMany(e => e.PersonalDataStrLists)
                .WithRequired(e => e.PersonalDataField)
                .HasForeignKey(e => e.PersonalDataFieldID);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.Fascn)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.ChuidOrgId)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.ChuidDuns)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.PiEmployeeAffiliation)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.PiAgencyCardSN)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.PiIssuerIdentification)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.PiOrgAffiliation1)
                .IsUnicode(false);

            modelBuilder.Entity<PivCard>()
                .Property(e => e.PiOrgAffiliation2)
                .IsUnicode(false);

            modelBuilder.Entity<PivCardIssuerCertificate>()
                .HasMany(e => e.PivCards)
                .WithRequired(e => e.PivCardIssuerCertificate)
                .HasForeignKey(e => e.IssuerSigCertSubjectKeyIdentifier);

            modelBuilder.Entity<Property>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RemoteElmo>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<ReportDefinition>()
                .Property(e => e.FileFormat)
                .IsUnicode(false);

            modelBuilder.Entity<ReportDefinition>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<ReportDefinition>()
                .HasOptional(e => e.ReportDefinitionEmailRecipient)
                .WithRequired(e => e.ReportDefinition);

            modelBuilder.Entity<ReportDefinition>()
                .HasMany(e => e.ReportDefinitionItems)
                .WithRequired(e => e.ReportDefinition)
                .HasForeignKey(e => e.ReportID);

            modelBuilder.Entity<ReportDefinition>()
                .HasOptional(e => e.ReportDefinitionSchedule)
                .WithRequired(e => e.ReportDefinition)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ReportDefinition>()
                .HasMany(e => e.ReportDefinitionScheduleTimes)
                .WithRequired(e => e.ReportDefinition)
                .HasForeignKey(e => e.ReportID);

            modelBuilder.Entity<ReportDefinitionItem>()
                .Property(e => e.ReferenceKey)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.CardholderRoles)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SADPlugin>()
                .Property(e => e.SadPluginName)
                .IsUnicode(false);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.ScheduleEntries)
                .WithRequired(e => e.Schedule)
                .HasForeignKey(e => e.ScheduleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SessionOperatorClub>()
                .HasMany(e => e.SessionOperatorRoutings)
                .WithRequired(e => e.SessionOperatorClub)
                .HasForeignKey(e => new { e.SessionID, e.OperatorClubID });

            modelBuilder.Entity<SharedBinary>()
                .HasMany(e => e.ReportDefinitions)
                .WithOptional(e => e.SharedBinary)
                .HasForeignKey(e => e.LogoGUID);

            modelBuilder.Entity<SharedBinary>()
                .HasMany(e => e.ReportDefinitions1)
                .WithOptional(e => e.SharedBinary1)
                .HasForeignKey(e => e.DisclaimerGUID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.AccessTriplets)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.AccessZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.AccessZone)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.AlarmDialler)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.AlarmKeypad)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.AlarmListNavPanelRules)
                .WithOptional(e => e.SiteItem)
                .HasForeignKey(e => e.SourceID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.AlarmZone)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.AustcoIntercom)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.Bert)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.BiometricReader)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.CarParkGroup)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.Class5ELM)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.ClubAlarmZones)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.AlarmZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.Door)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.DVRCameras)
                .WithOptional(e => e.SiteItem)
                .HasForeignKey(e => e.DVRTypeID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.EventGroupDefaultInstructions)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.EventGroupItemActionPlans)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.EventGroupItemAlarmInstructions)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.EventTypeDefaultInstructions)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.EventTypeItemAlarmInstructions)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.FenceController)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.FenceZone)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.FieldDevices)
                .WithOptional(e => e.SiteItem)
                .HasForeignKey(e => e.ParentDeviceID);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.FieldDevice)
                .WithRequired(e => e.SiteItem1);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.Frazzle)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.Frazzles)
                .WithOptional(e => e.SiteItem1)
                .HasForeignKey(e => e.HighTemperatureOutputID);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.GBusURI)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.GuardTour)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.HBUSAlarmsTerminal)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.HBUSIOBoard)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.HBUSReader)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.HBUSTerminalIdleImage)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.HBUSTerminal)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.InterlockSetting)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.LiftCar)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.LiftCarLevels)
                .WithOptional(e => e.SiteItem)
                .HasForeignKey(e => e.InputID);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.RemoteElmo)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.SaltoAccessTriplets)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SaltoAccessZoneID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.SaltoServer)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.SchindlerIDSystem)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.Overrides)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.DoorID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.ReflectIOPairs)
                .WithOptional(e => e.SiteItem)
                .HasForeignKey(e => e.InputID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.SiteItemCameraPairs)
                .WithRequired(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID);

            modelBuilder.Entity<SiteItem>()
                .HasMany(e => e.SitePlanGraphics)
                .WithOptional(e => e.SiteItem)
                .HasForeignKey(e => e.SiteItemID);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.SoftwareProcess)
                .WithRequired(e => e.SiteItem);

            modelBuilder.Entity<SiteItem>()
                .HasOptional(e => e.TautWireGroup)
                .WithRequired(e => e.SiteItem)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SitePlan>()
                .HasMany(e => e.SitePlan1)
                .WithOptional(e => e.SitePlan2)
                .HasForeignKey(e => e.ParentSitePlanID);

            modelBuilder.Entity<SitePlan>()
                .HasMany(e => e.SitePlanGraphics)
                .WithRequired(e => e.SitePlan)
                .HasForeignKey(e => e.SitePlanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SitePlan>()
                .HasMany(e => e.SitePlanLinks)
                .WithRequired(e => e.SitePlan)
                .HasForeignKey(e => e.TargetSitePlanID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SitePlanGraphic>()
                .HasMany(e => e.SitePlanGraphicItems)
                .WithRequired(e => e.SitePlanGraphic)
                .HasForeignKey(e => e.GraphicID);

            modelBuilder.Entity<SoftwareProcess>()
                .HasOptional(e => e.WorkstationBase)
                .WithRequired(e => e.SoftwareProcess)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SpotMonitorViewerRule>()
                .HasMany(e => e.SpotMonitorViewerRuleDivisionItemTypes)
                .WithRequired(e => e.SpotMonitorViewerRule)
                .HasForeignKey(e => new { e.FTItemID, e.RuleID });

            modelBuilder.Entity<SpringType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SpringType>()
                .HasMany(e => e.TautWireGroups)
                .WithRequired(e => e.SpringType1)
                .HasForeignKey(e => e.SpringType);

            modelBuilder.Entity<Viewer>()
                .HasOptional(e => e.AlarmListConfig)
                .WithRequired(e => e.Viewer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Viewer>()
                .HasMany(e => e.AlarmListNavPanelRules)
                .WithRequired(e => e.Viewer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Viewer>()
                .HasOptional(e => e.AustcoIntercomViewerConfig)
                .WithRequired(e => e.Viewer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Viewer>()
                .HasOptional(e => e.ControlledChallengeViewerConfig)
                .WithRequired(e => e.Viewer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Viewer>()
                .HasOptional(e => e.JacquesIntercomViewerConfig)
                .WithRequired(e => e.Viewer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Viewer>()
                .HasOptional(e => e.SpotMonitorViewer)
                .WithRequired(e => e.Viewer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Viewer>()
                .HasMany(e => e.ViewerOperatorGroupPairs)
                .WithRequired(e => e.Viewer)
                .HasForeignKey(e => e.ViewerID);

            modelBuilder.Entity<ViewerPanel>()
                .HasMany(e => e.AustcoIntercomViewerConfigs)
                .WithOptional(e => e.ViewerPanel)
                .HasForeignKey(e => e.DefaultPanelID);

            modelBuilder.Entity<ViewerPanel>()
                .HasMany(e => e.ControlledChallengeViewerConfigs)
                .WithOptional(e => e.ViewerPanel)
                .HasForeignKey(e => e.DefaultPanelID);

            modelBuilder.Entity<ViewerPanel>()
                .HasMany(e => e.JacquesIntercomViewerConfigs)
                .WithOptional(e => e.ViewerPanel)
                .HasForeignKey(e => e.DefaultPanelID);

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.AccessDecisionTileConfig)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.CardholderCardsTileConfig)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.CardholderDetailsTile)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.CardholderFingerprintsTile)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.CardholderImagesTile)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.DVRCameraTileConfig)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.EventTrailTile)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.GuardTourTileConfig)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.SitePlanTileConfig)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.StatusTile)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.TagBoardTile)
                .WithRequired(e => e.ViewerPanelTile);

            modelBuilder.Entity<ViewerPanelTile>()
                .HasOptional(e => e.UrlTile)
                .WithRequired(e => e.ViewerPanelTile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VisitVisitor>()
                .HasMany(e => e.VisitVisitorAccessGroups)
                .WithRequired(e => e.VisitVisitor)
                .HasForeignKey(e => new { e.FTItemID, e.CardholderID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VisitVisitor>()
                .HasMany(e => e.VisitVisitorActions)
                .WithRequired(e => e.VisitVisitor)
                .HasForeignKey(e => new { e.FTItemID, e.CardholderID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VisitVisitor>()
                .HasMany(e => e.VisitVisitorNotificationLogs)
                .WithRequired(e => e.VisitVisitor)
                .HasForeignKey(e => new { e.FTItemID, e.CardholderID });

            modelBuilder.Entity<VisitVisitor>()
                .HasMany(e => e.VisitVisitorStatusChanges)
                .WithRequired(e => e.VisitVisitor)
                .HasForeignKey(e => new { e.FTItemID, e.CardholderID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WireType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<WireType>()
                .HasMany(e => e.TautWireGroups)
                .WithRequired(e => e.WireType1)
                .HasForeignKey(e => e.WireType);

            modelBuilder.Entity<Wizard>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Workstation>()
                .Property(e => e.AustcoNodeSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<Workstation>()
                .Property(e => e.AustcoAudioSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<Workstation>()
                .HasMany(e => e.WorkstationRoutingWorkstations)
                .WithRequired(e => e.Workstation)
                .HasForeignKey(e => e.WorkstationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkstationBase>()
                .HasOptional(e => e.MobileDevice)
                .WithRequired(e => e.WorkstationBase)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WorkstationBase>()
                .HasMany(e => e.OperatorSessions)
                .WithOptional(e => e.WorkstationBase)
                .HasForeignKey(e => e.WorkstationID);

            modelBuilder.Entity<WorkstationBase>()
                .HasOptional(e => e.Workstation)
                .WithRequired(e => e.WorkstationBase)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WorkstationRouting>()
                .HasMany(e => e.SessionOperatorRoutings)
                .WithRequired(e => e.WorkstationRouting)
                .HasForeignKey(e => e.WorkstationRoutingID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkstationRouting>()
                .HasMany(e => e.WorkstationRoutingLinkedItems)
                .WithRequired(e => e.WorkstationRouting)
                .HasForeignKey(e => e.LinkedItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DBTemplateRestoreHook>()
                .Property(e => e.HookName)
                .IsUnicode(false);

            modelBuilder.Entity<ElmoMessage>()
                .Property(e => e.ExpiryTime)
                .HasPrecision(0);

            modelBuilder.Entity<Licence>()
                .Property(e => e.Revision)
                .IsFixedLength();

            modelBuilder.Entity<OperatorExpiredPassword>()
                .Property(e => e.EncryptedPassword)
                .IsFixedLength();

            modelBuilder.Entity<PivCardCertPolicy>()
                .Property(e => e.PolicyOid)
                .IsUnicode(false);

            modelBuilder.Entity<PivCardCertPolicy>()
                .Property(e => e.AgencyCodes)
                .IsUnicode(false);

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailOutAccount)
                .IsUnicode(false);

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailOutServer)
                .IsUnicode(false);

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifySMSOutDomain)
                .IsUnicode(false);

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailInAccount)
                .IsUnicode(false);

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailInServer)
                .IsUnicode(false);

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailOutPassword)
                .IsFixedLength();

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailInPassword)
                .IsFixedLength();

            modelBuilder.Entity<SingleValue>()
                .Property(e => e.NotifyEmailOutSender)
                .IsUnicode(false);
        }
    }
}
