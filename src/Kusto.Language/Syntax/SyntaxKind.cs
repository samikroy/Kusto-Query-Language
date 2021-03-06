﻿namespace Kusto.Language.Syntax
{
    /// <summary>
    /// All the kinds of tokens that appear in Kusto 
    /// </summary>
    /// <remarks>
    /// Note for implementors: Are you adding a new value to this enum?
    /// Be sure to also add a new entry referencing it to the
    /// <see cref="SyntaxFacts"/> table.
    /// </remarks>
    public enum SyntaxKind
    {
        None = 0,

        // keywords
        AccessKeyword,
        AccountsKeyword,
        AccumulateKeyword,
        AddKeyword,
        AdminKeyword,
        AdminsKeyword,
        AliasKeyword,
        AllKeyword,
        AlterKeyword,
        AlterMergeKeyword,
        AndKeyword,
        AppendKeyword,
        ArtifactsKeyword,
        AsKeyword,
        AscKeyword,
        AsyncKeyword,
        AttachKeyword,

        BagExpansionKeyword,
        BasicAuthKeyword,
        BetweenKeyword,
        BinKeyword,
        BinLegacyKeyword,
        ByKeyword,

        CacheKeyword,
        CachingKeyword,
        CachingPolicyKeyword,
        CalloutKeyword,
        CancelKeyword,
        CapacityKeyword,
        CharactersKeyword,
        ClusterKeyword,
        ColumnKeyword,
        ColumnsKeyword,
        ColumnDocStringsKeyword,
        CommandsKeyword,
        CommandsAndQueriesKeyword,
        CommPoolsKeyword,
        CompletedKeyword,
        CompressedKeyword,
        ConsumeKeyword,
        ContainsKeyword,
        ContainsCsKeyword,
        Contains_CsKeyword,
        ContinuousExport,
        ContinuousExports,
        CountKeyword,
        CrashKeyword,
        CreateKeyword,
        CreateOrAlterKeyword,
        CreatedOnKeyword,
        CreateMergeKeyword,
        CrossDbKeyword,
        CrossClusterKeyword,
        CslKeyword,
        CslSchemaKeyword,
        CsvKeyword,

        DataKeyword,
        DatabaseKeyword,
        DatabaseCreatorsKeyword,
        DatabasesKeyword,
        DataScopeKeyword,
        DataTableKeyword,
        DeclareKeyword,
        DecryptionCertificateThumbPrintKeyword,
        DefaultKeyword,
        DefineKeyword,
        DeleteKeyword,
        DescKeyword,
        DetachKeyword,
        DetailsKeyword,
        DiagnosticsKeyword,
        DisableKeyword,
        DistinctKeyword,
        DocStringKeyword,
        DropKeyword,
        DropPretendKeyword,
        DupNextFailedIngestKeyword,
        DupNextIngestKeyword,

        EarliestKeyword,
        EchoKeyword,
        EffectiveKeyword,
        EnableKeyword,
        EncodingKeyword,
        EncodingPolicyKeyword,
        EndsWithKeyword,
        EndsWithCsKeyword,
        EntityKeyword,
        EphemeralKeyword,
        EvaluateKeyword,
        ExceptKeyword,
        ExecuteKeyword,
        ExecuteAndCacheKeyword,
        ExpandOutputKeyword,
        ExportKeyword,
        ExtendKeyword,
        ExtentKeyword,
        ExtentContainersKeyword,
        ExtentsKeyword,
        ExtentsMergeKeyword,
        ExternalKeyword,
        ExternalDataKeyword,
        External_DataKeyword,

        FabricKeyword,
        FabricCacheKeyword,
        FabricClocksKeyword,
        FabricLocksKeyword,
        FacetKeyword,
        FailuresKeyword,

        FilterKeyword,
        FindKeyword,
        FirstKeyword,
        FlagsKeyword,
        FolderKeyword,
        ForceKeyword,
        ForkKeyword,
        FreshnessKeyword,
        FromKeyword,
        FunctionKeyword,
        FunctionsKeyword,

        GetSchemaKeyword,
        GroupsKeyword,

        HardDeleteKeyword,
        HasKeyword,
        HasAnyKeyword,
        HasCsKeyword,
        HashKeyword,
        HasPrefixKeyword,
        HasPrefixCsKeyword,
        HasSuffixKeyword,
        HasSuffixCsKeyword,
        HintDotConcurrencyKeyword,
        HintDotDistributionKeyword,
        HintDotMaterializedKeyword,
        HintDotNumPartitions,
        HintDotShuffleKeyKeyword,
        HintDotSpreadKeyword,
        HintDotRemoteKeyword,
        HintDotStrategyKeyword,
        HintDotProgressiveTopKeyword,
        HotCacheKeyword,
        HotKeyword,
        HotDataKeyword,
        HotIndexKeyword,
        HoursKeyword,

        IdKeyword,
        IfLaterThanKeyword,
        IfExistsKeyword,
        IfNotExistsKeyword,
        InKeyword,
        InCsKeyword,
        IngestKeyword,
        IngestionKeyword,
        IngestionsKeyword,
        IngestionTimeKeyword,
        IngestorsKeyword,
        InlineKeyword,
        IsFuzzyKeyword,
        _IsFuzzyKeyword,
        IntoKeyword,
        InvokeKeyword,

        JoinKeyword,
        JournalKeyword,
        JsonKeyword,

        KeysKeyword,
        KindKeyword,

        LastKeyword,
        LatestKeyword,
        LetKeyword,
        LikeKeyword,
        LikeCsKeyword,
        LimitKeyword,
        LoadKeyword,
        LocalKeyword,
        LookupKeyword,

        MakeSeriesKeyword,
        MappingKeyword,
        MappingsKeyword,
        MatchesRegexKeyword,
        MaterializeKeyword,
        MaterializedViewCombineKeyword,
        MdmKeyword,
        MemoryKeyword,
        MergeKeyword,
        MetadataKeyword,
        MissingKeyword,
        MonitoringKeyword,
        MoveKeyword,
        MvApplyKeyword,
        MvDashApplyKeyword,
        MvDashExpandKeyword,
        MvExpandKeyword,

        NanKeyword,
        NoneKeyword,
        NotBetweenKeyword,
        NotContainsKeyword,
        NotContainsCsKeyword,
        NotBangContainsKeyword,
        NotBangContainsCsKeyword,
        NotEndsWithKeyword,
        NotEndsWithCsKeyword,
        NotHasKeyword,
        NotHasCsKeyword,
        NotHasPrefixKeyword,
        NotHasPrefixCsKeyword,
        NotHasSuffixKeyword,
        NotHasSuffixCsKeyword,
        NotInKeyword,
        NotInCsKeyword,
        NotLikeKeyword,
        NotLikeCsKeyword,
        NotStartsWithKeyword,
        NotStartsWithCsKeyword,
        NullKeyword,
        NullsKeyword,

        OfKeyword,
        OnKeyword,
        OlderKeyword,
        OperationsKeyword,
        OrKeyword,
        OrderKeyword,
        OthersKeyword,

        PackKeyword,
        PackedColumnKeyword,
        ParseKeyword,
        ParseWhereKeyword,
        PartitionKeyword,
        PartitioningKeyword,
        PasswordKeyword,
        PatternKeyword,
        PersistKeyword,
        PluginKeyword,
        PluginsKeyword,
        PoliciesKeyword,
        PolicyKeyword,
        PretendKeyword,
        PrettyNameKeyword,
        PrincipalKeyword,
        PrincipalsKeyword,
        PrintKeyword,
        ProjectKeyword,
        ProjectAwayKeyword,
        _ProjectAwayKeyword,
        ProjectRenameKeyword,
        ProjectReorderKeyword,
        ProjectSmartKeyword,
        PurgeKeyword,
        PurgeCleanupKeyword,

        QueriesKeyword,
        QueryKeyword,
        QueryParametersKeyword,
        QueryExecutionKeyword,
        QueryPlanKeyword,
        QueryThrottlingKeyword,
        QuickKeyword,

        RangeKeyword,
        ReadOnlyKeyword,
        ReadWriteKeyword,
        RebalanceKeyword,
        RebalancePretendKeyword,
        RebuildKeyword,
        RecycleKeyword,
        ReduceKeyword,
        RegexKeyword,
        RelaxedKeyword,
        RenameKeyword,
        RenderKeyword,
        ReplaceKeyword,
        ResetKeyword,
        RestrictKeyword,
        RetentionKeyword,
        RolesKeyword,
        RowOrderKeyword,
        RowOrderPolicyKeyword,
        RowStoreKeyword,
        RowStorePolicyKeyword,
        RowStoresKeyword,
        RunKeyword,
        RunningKeyword,

        SampleKeyword,
        SampleDistinctKeyword,
        SandboxKeyword,
        SandboxesKeyword,
        SaveKeyword,
        SchemaKeyword,
        ScriptKeyword,
        SealKeyword,
        SearchKeyword,
        SerializeKeyword,
        SetKeyword,
        SetOrAppendKeyword,
        SetOrReplaceKeyword,
        ShardingKeyword,
        ShowKeyword,
        SimpleKeyword,
        SoftDeleteKeyword,
        SortKeyword,
        SourceColumnIndexKeyword,
        SqlKeyword,
        StartsWithKeyword,
        StartsWithCsKeyword,
        StateKeyword,
        StepKeyword,
        StreamKeyword,
        SummarizeKeyword,
        StorageKeyword,

        TableKeyword,
        TablePurgeKeyword,
        TablesKeyword,
        TagsKeyword,
        TakeKeyword,
        TempStorageKeyword,
        ThresholdKeyword,
        ThrowKeyword,
        TimeoutKeyword,
        TitleKeyword,
        ToKeyword,
        TopKeyword,
        TopHittersKeyword,
        TopNestedKeyword,
        ToScalarKeyword,
        ToTableKeyword,
        TraceKeyword,
        TraceResultsKeyword,
        TsvKeyword,
        TypeKeyword,
        TypeOfKeyword,

        UndoKeyword,
        UnionKeyword,
        UpdateKeyword,
        UserKeyword,
        UsersKeyword,
        UuidKeyword,

        VerboseKeyword,
        VersionKeyword,
        ViewKeyword,
        ViewersKeyword,
        VolatileKeyword,

        WarmKeyword,
        WarmingKeyword,
        WhatIfKeyword,
        WhereKeyword,
        WithKeyword,
        WriteAheadLogKeyword,

        // scalar type keyword tokens
        BoolKeyword,
        BooleanKeyword,
        Int8Keyword,
        CharKeyword,
        UInt8Keyword,
        ByteKeyword,
        Int16Keyword,
        UInt16Keyword,
        IntKeyword,
        Int32Keyword,
        UIntKeyword,
        UInt32Keyword,
        LongKeyword,
        Int64Keyword,
        ULongKeyword,
        UInt64Keyword,
        SingleKeyword,
        FloatKeyword,
        RealKeyword,
        DecimalKeyword,
        DoubleKeyword,
        StringKeyword,
        TimeKeyword,
        TimespanKeyword,
        DateKeyword,
        DateTimeKeyword,
        GuidKeyword,
        UniqueIdKeyword,
        DynamicKeyword,

        // punctuation tokens
        OpenParenToken,
        CloseParenToken,
        OpenBracketToken,
        CloseBracketToken,
        OpenBraceToken,
        CloseBraceToken,
        BarToken,
        LessThanBarToken,
        PlusToken,
        MinusToken,
        AsteriskToken,
        SlashToken,
        PercentToken,
        DotToken,
        DotDotToken,
        BangToken,
        LessThanToken,
        LessThanOrEqualToken,
        GreaterThanToken,
        GreaterThanOrEqualToken,
        EqualToken,
        EqualEqualToken,
        BangEqualToken,
        LessThanGreaterThanToken,
        ColonToken,
        SemicolonToken,
        CommaToken,
        EqualTildeToken,
        BangTildeToken,
        AtToken,
        QuestionToken,

        // literal tokens
        BooleanLiteralToken,
        IntLiteralToken,
        LongLiteralToken,
        RealLiteralToken,
        DecimalLiteralToken,
        DateTimeLiteralToken,
        TimespanLiteralToken,
        GuidLiteralToken,
        StringLiteralToken,

        // other tokens
        IdentifierToken,
        DirectiveToken,
        EndOfTextToken,
        BadToken,

        // nodes
        List,
        SeparatedElement,
        ExpressionList,
        ExpressionCouple,
        RenameList,
        CustomNode,

        // literal expressions (kinds for LiteralExpression node)
        BooleanLiteralExpression,
        IntLiteralExpression,
        LongLiteralExpression,
        RealLiteralExpression,
        DecimalLiteralExpression,
        DateTimeLiteralExpression,
        TimespanLiteralExpression,
        GuidLiteralExpression,
        StringLiteralExpression,
        NullLiteralExpression,
        TokenLiteralExpression,  // any token (keyword/identifier/etc)

        // special literal expressions (each has own type)
        CompoundStringLiteralExpression,
        TypeOfLiteralExpression,

        // dynamic/json expressions
        DynamicExpression,
        JsonObjectExpression,
        JsonPair,
        JsonArrayExpression,

        // names
        TokenName,
        BrackettedName,
        BracedName, // client parameters
        WildcardedName,
        NameDeclaration,
        NameReference,

        ParenthesizedExpression,
        PathExpression,
        ElementExpression,
        SimpleNamedExpression,
        CompoundNamedExpression,
        FunctionCallExpression,
        ToScalarExpression,
        ToTableExpression,
        BrackettedExpression,
        ConditionedExpression,
        PipeExpression,
        NamedParameter,
        DataScopeExpression,
        DataTableExpression,
        ExternalDataExpression,
        ExternalDataWithClause,
        ExternalDataUriList,
        MaterializedViewCombineExpression,
        MaterializedViewCombineClause,

        // nullary?
        StarExpression,
        AtExpression,

        // unary operators
        UnaryPlusExpression,
        UnaryMinusExpression,

        // binary operators
        AddExpression,
        SubtractExpression,
        MultiplyExpression,
        DivideExpression,
        ModuloExpression,
        LessThanExpression,
        LessThanOrEqualExpression,
        GreaterThanExpression,
        GreaterThanOrEqualExpression,
        EqualExpression,
        NotEqualExpression,
        AndExpression,
        OrExpression,
        InExpression,
        InCsExpression,
        NotInExpression,
        NotInCsExpression,
        BetweenExpression,
        NotBetweenExpression,

        // string binary operators
        EqualTildeExpression, // equal - ignore case
        BangTildeExpression,  // not equal - ignore case
        HasExpression,
        HasCsExpression,
        NotHasExpression,
        NotHasCsExpression,
        HasPrefixExpression,
        HasPrefixCsExpression,
        NotHasPrefixExpression,
        NotHasPrefixCsExpression,
        HasSuffixExpression,
        HasSuffixCsExpression,
        NotHasSuffixExpression,
        NotHasSuffixCsExpression,
        LikeExpression,
        LikeCsExpression,
        NotLikeExpression,
        NotLikeCsExpression,
        ContainsExpression,
        ContainsCsExpression,
        NotContainsExpression,
        NotContainsCsExpression,
        StartsWithExpression,
        StartsWithCsExpression,
        NotStartsWithExpression,
        NotStartsWithCsExpression,
        EndsWithExpression,
        EndsWithCsExpression,
        NotEndsWithExpression,
        NotEndsWithCsExpression,
        MatchesRegexExpression,
        SearchExpression,
        HasAnyExpression,

        // common command-related expressions & clauses
        TypedColumnReference,
        PackExpression,
        NameAndTypeDeclaration,
        PrimitiveTypeExpression,
        SchemaTypeExpression,
        NameEqualsClause,
        DefaultExpressionClause,
        ToTypeOfClause,

        // query operators
        BadQueryOperator,

        AsOperator,

        ConsumeOperator,

        CountOperator,
        CountAsIdentifierClause,

        DistinctOperator,

        ExecuteAndCacheOperator,
        ExtendOperator,

        FacetOperator,
        FacetWithOperatorClause,
        FacetWithExpressionClause,

        FilterOperator,
        FindOperator,
        DataScopeClause,
        FindInClause,
        FindProjectClause,

        GetSchemaOperator,

        InvokeOperator,

        LookupOperator,
        JoinOperator,
        JoinOnClause,
        JoinWhereClause,

        SearchOperator,

        ForkOperator,
        ForkExpression,

        MakeSeriesOperator,
        MakeSeriesExpression,
        MakeSeriesOnClause,
        MakeSeriesInRangeClause,
        MakeSeriesFromClause,
        MakeSeriesToClause,
        MakeSeriesStepClause,
        MakeSeriesFromToStepClause,
        MakeSeriesByClause,

        MvApplyOperator,
        MvApplyExpression,
        MvApplyRowLimitClause,
        MvApplyContextIdClause,
        MvApplySubqueryExpression,

        MvExpandOperator,
        MvExpandExpression,
        MvExpandRowLimitClause,

        PartitionSubquery,
        PartitionQuery,
        PartitionScope,
        PartitionOperator,
        ParseOperator,
        ParseWhereOperator,

        EvaluateOperator,

        ProjectOperator,
        ProjectAwayOperator,
        ProjectRenameOperator,
        ProjectReorderOperator,

        RangeOperator,

        ReduceByOperator,
        ReduceByWithClause,

        RenderOperator,
        RenderWithClause,
        RenderNameList,

        SampleOperator,
        SampleDistinctOperator,

        SerializeOperator,

        SortOperator,
        OrderedExpression,
        OrderingClause,
        OrderingNullsClause,

        SummarizeOperator,
        SummarizeByClause,

        TakeOperator,

        TopHittersOperator,
        TopHittersByClause,
        TopOperator,
        TopNestedOperator,
        TopNestedClause,
        TopNestedWithOthersClause,

        UnionOperator,

        PrintOperator,

        // statements
        AliasStatement,

        ExpressionStatement,

        FunctionDeclaration,
        FunctionParameters,
        FunctionParameter,
        DefaultValueDeclaration,
        FunctionBody,

        LetStatement,

        MaterializeExpression,

        RestrictStatement,

        SetOptionStatement,
        OptionValueClause,

        PatternStatement,
        PatternDeclaration,
        PatternPathParameter,
        PatternMatch,
        PatternPathValue,

        QueryParametersStatement,

        // commands
        CommandWithValueClause,
        CommandWithPropertyListClause,
        BadCommand,
        UnknownCommand,
        CustomCommand,

        // other
        QueryBlock,
        CommandBlock,
        DirectiveBlock,
        SkippedTokens,
        InputTextToken,
    }
}