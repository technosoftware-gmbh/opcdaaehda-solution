﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=1.1.4322.573.
// 

using System;
using System.Data;
using System.Runtime.Serialization;
using System.Xml;

namespace SampleClients.Hda.Test
{
}

namespace SampleClients.Hda.Test {
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class DataSet : System.Data.DataSet {
        
        private TestCasesDataTable tableTestCases_;
        
        private ItemValuesDataTable tableItemValues_;
        
        private DataRelation relationTestCaseItemValue_;
        
        public DataSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected DataSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["TestCase"] != null)) {
                    this.Tables.Add(new TestCasesDataTable(ds.Tables["TestCase"]));
                }
                if ((ds.Tables["TsCHdaItemValue"] != null)) {
                    this.Tables.Add(new ItemValuesDataTable(ds.Tables["TsCHdaItemValue"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TestCasesDataTable TestCases {
            get {
                return this.tableTestCases_;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ItemValuesDataTable ItemValues {
            get {
                return this.tableItemValues_;
            }
        }
        
        public override System.Data.DataSet Clone() {
            DataSet cln = ((DataSet)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["TestCase"] != null)) {
                this.Tables.Add(new TestCasesDataTable(ds.Tables["TestCase"]));
            }
            if ((ds.Tables["TsCHdaItemValue"] != null)) {
                this.Tables.Add(new ItemValuesDataTable(ds.Tables["TsCHdaItemValue"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableTestCases_ = ((TestCasesDataTable)(this.Tables["TestCase"]));
            if ((this.tableTestCases_ != null)) {
                this.tableTestCases_.InitVars();
            }
            this.tableItemValues_ = ((ItemValuesDataTable)(this.Tables["TsCHdaItemValue"]));
            if ((this.tableItemValues_ != null)) {
                this.tableItemValues_.InitVars();
            }
            this.relationTestCaseItemValue_ = this.Relations["TestCase_ItemValue"];
        }
        
        private void InitClass() {
            this.DataSetName = "_DataSet";
            this.Prefix = "";
            this.Namespace = "http://opcfoundation.org/Hda/1.2/";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableTestCases_ = new TestCasesDataTable();
            this.Tables.Add(this.tableTestCases_);
            this.tableItemValues_ = new ItemValuesDataTable();
            this.Tables.Add(this.tableItemValues_);
            ForeignKeyConstraint fkc;
            fkc = new ForeignKeyConstraint("TestCase_ItemValue", new DataColumn[] {
                        this.tableTestCases_.TestCaseIdColumn}, new DataColumn[] {
                        this.tableItemValues_.TestCaseIdColumn});
            this.tableItemValues_.Constraints.Add(fkc);
            fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None;
            fkc.DeleteRule = System.Data.Rule.Cascade;
            fkc.UpdateRule = System.Data.Rule.Cascade;
            this.relationTestCaseItemValue_ = new DataRelation("TestCase_ItemValue", new DataColumn[] {
                        this.tableTestCases_.TestCaseIdColumn}, new DataColumn[] {
                        this.tableItemValues_.TestCaseIdColumn}, false);
            this.relationTestCaseItemValue_.Nested = true;
            this.Relations.Add(this.relationTestCaseItemValue_);
        }
        
        private bool ShouldSerializeTestCases() {
            return false;
        }
        
        private bool ShouldSerializeItemValues() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void TestCaseChangeEventHandler(object sender, TestCaseChangeEvent e);
        
        public delegate void ItemValueChangeEventHandler(object sender, ItemValueChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TestCasesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnName_;
            
            private DataColumn columnAggregateId_;
            
            private DataColumn columnStartTime_;
            
            private DataColumn columnEndTime_;
            
            private DataColumn columnMaxValues_;
            
            private DataColumn columnIncludeBounds_;
            
            private DataColumn columnResampleInterval_;
            
            private DataColumn columnResultId_;
            
            private DataColumn columnTestCaseId_;
            
            internal TestCasesDataTable() : 
                    base("TestCase") {
                this.InitClass();
            }
            
            internal TestCasesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn NameColumn {
                get {
                    return this.columnName_;
                }
            }
            
            internal DataColumn AggregateIdColumn {
                get {
                    return this.columnAggregateId_;
                }
            }
            
            internal DataColumn StartTimeColumn {
                get {
                    return this.columnStartTime_;
                }
            }
            
            internal DataColumn EndTimeColumn {
                get {
                    return this.columnEndTime_;
                }
            }
            
            internal DataColumn MaxValuesColumn {
                get {
                    return this.columnMaxValues_;
                }
            }
            
            internal DataColumn IncludeBoundsColumn {
                get {
                    return this.columnIncludeBounds_;
                }
            }
            
            internal DataColumn ResampleIntervalColumn {
                get {
                    return this.columnResampleInterval_;
                }
            }
            
            internal DataColumn ResultIdColumn {
                get {
                    return this.columnResultId_;
                }
            }
            
            internal DataColumn TestCaseIdColumn {
                get {
                    return this.columnTestCaseId_;
                }
            }
            
            public TestCase this[int index] {
                get {
                    return ((TestCase)(this.Rows[index]));
                }
            }
            
            public event TestCaseChangeEventHandler TestCaseChanged;
            
            public event TestCaseChangeEventHandler TestCaseChanging;
            
            public event TestCaseChangeEventHandler TestCaseDeleted;
            
            public event TestCaseChangeEventHandler TestCaseDeleting;
            
            public void AddTestCase(TestCase row) {
                this.Rows.Add(row);
            }
            
            public TestCase AddTestCase(string name, int aggregateId, System.Decimal startTime, System.Decimal endTime, int maxValues, bool includeBounds, System.Decimal resampleInterval, string resultId) {
                TestCase rowTestCase = ((TestCase)(this.NewRow()));
                rowTestCase.ItemArray = new object[] {
                        name,
                        aggregateId,
                        startTime,
                        endTime,
                        maxValues,
                        includeBounds,
                        resampleInterval,
                        resultId,
                        null};
                this.Rows.Add(rowTestCase);
                return rowTestCase;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                TestCasesDataTable cln = ((TestCasesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new TestCasesDataTable();
            }
            
            internal void InitVars() {
                this.columnName_ = this.Columns["Name"];
                this.columnAggregateId_ = this.Columns["AggregateID"];
                this.columnStartTime_ = this.Columns["StartTime"];
                this.columnEndTime_ = this.Columns["EndTime"];
                this.columnMaxValues_ = this.Columns["MaxValues"];
                this.columnIncludeBounds_ = this.Columns["IncludeBounds"];
                this.columnResampleInterval_ = this.Columns["ResampleInterval"];
                this.columnResultId_ = this.Columns["ResultID"];
                this.columnTestCaseId_ = this.Columns["TestCase_Id"];
            }
            
            private void InitClass() {
                this.columnName_ = new DataColumn("Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnName_);
                this.columnAggregateId_ = new DataColumn("AggregateID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAggregateId_);
                this.columnStartTime_ = new DataColumn("StartTime", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStartTime_);
                this.columnEndTime_ = new DataColumn("EndTime", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEndTime_);
                this.columnMaxValues_ = new DataColumn("MaxValues", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMaxValues_);
                this.columnIncludeBounds_ = new DataColumn("IncludeBounds", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIncludeBounds_);
                this.columnResampleInterval_ = new DataColumn("ResampleInterval", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnResampleInterval_);
                this.columnResultId_ = new DataColumn("ResultID", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnResultId_);
                this.columnTestCaseId_ = new DataColumn("TestCase_Id", typeof(int), null, System.Data.MappingType.Hidden);
                this.Columns.Add(this.columnTestCaseId_);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnTestCaseId_}, true));
                this.columnTestCaseId_.AutoIncrement = true;
                this.columnTestCaseId_.AllowDBNull = false;
                this.columnTestCaseId_.Unique = true;
            }
            
            public TestCase NewTestCase() {
                return ((TestCase)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new TestCase(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(TestCase);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TestCaseChanged != null)) {
                    this.TestCaseChanged(this, new TestCaseChangeEvent(((TestCase)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TestCaseChanging != null)) {
                    this.TestCaseChanging(this, new TestCaseChangeEvent(((TestCase)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TestCaseDeleted != null)) {
                    this.TestCaseDeleted(this, new TestCaseChangeEvent(((TestCase)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TestCaseDeleting != null)) {
                    this.TestCaseDeleting(this, new TestCaseChangeEvent(((TestCase)(e.Row)), e.Action));
                }
            }
            
            public void RemoveTestCase(TestCase row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TestCase : DataRow {
            
            private TestCasesDataTable tableTestCases_;
            
            internal TestCase(DataRowBuilder rb) : 
                    base(rb) {
                this.tableTestCases_ = ((TestCasesDataTable)(this.Table));
            }
            
            public string Name {
                get {
                    if (this.IsNameNull()) {
                        return null;
                    }
                    else {
                        return ((string)(this[this.tableTestCases_.NameColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.NameColumn] = value;
                }
            }
            
            public int AggregateId {
                get {
                    if (this.IsAggregateIdNull()) {
                        return 0;
                    }
                    else {
                        return ((int)(this[this.tableTestCases_.AggregateIdColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.AggregateIdColumn] = value;
                }
            }
            
            public System.Decimal StartTime {
                get {
                    if (this.IsStartTimeNull()) {
                        return 0m;
                    }
                    else {
                        return ((System.Decimal)(this[this.tableTestCases_.StartTimeColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.StartTimeColumn] = value;
                }
            }
            
            public System.Decimal EndTime {
                get {
                    if (this.IsEndTimeNull()) {
                        return 0m;
                    }
                    else {
                        return ((System.Decimal)(this[this.tableTestCases_.EndTimeColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.EndTimeColumn] = value;
                }
            }
            
            public int MaxValues {
                get {
                    if (this.IsMaxValuesNull()) {
                        return 0;
                    }
                    else {
                        return ((int)(this[this.tableTestCases_.MaxValuesColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.MaxValuesColumn] = value;
                }
            }
            
            public bool IncludeBounds {
                get {
                    if (this.IsIncludeBoundsNull()) {
                        return false;
                    }
                    else {
                        return ((bool)(this[this.tableTestCases_.IncludeBoundsColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.IncludeBoundsColumn] = value;
                }
            }
            
            public System.Decimal ResampleInterval {
                get {
                    if (this.IsResampleIntervalNull()) {
                        return 0m;
                    }
                    else {
                        return ((System.Decimal)(this[this.tableTestCases_.ResampleIntervalColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.ResampleIntervalColumn] = value;
                }
            }
            
            public string ResultId {
                get {
                    if (this.IsResultIdNull()) {
                        return "S_OK";
                    }
                    else {
                        return ((string)(this[this.tableTestCases_.ResultIdColumn]));
                    }
                }
                set {
                    this[this.tableTestCases_.ResultIdColumn] = value;
                }
            }
            
            public bool IsNameNull() {
                return this.IsNull(this.tableTestCases_.NameColumn);
            }
            
            public void SetNameNull() {
                this[this.tableTestCases_.NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsAggregateIdNull() {
                return this.IsNull(this.tableTestCases_.AggregateIdColumn);
            }
            
            public void SetAggregateIdNull() {
                this[this.tableTestCases_.AggregateIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsStartTimeNull() {
                return this.IsNull(this.tableTestCases_.StartTimeColumn);
            }
            
            public void SetStartTimeNull() {
                this[this.tableTestCases_.StartTimeColumn] = System.Convert.DBNull;
            }
            
            public bool IsEndTimeNull() {
                return this.IsNull(this.tableTestCases_.EndTimeColumn);
            }
            
            public void SetEndTimeNull() {
                this[this.tableTestCases_.EndTimeColumn] = System.Convert.DBNull;
            }
            
            public bool IsMaxValuesNull() {
                return this.IsNull(this.tableTestCases_.MaxValuesColumn);
            }
            
            public void SetMaxValuesNull() {
                this[this.tableTestCases_.MaxValuesColumn] = System.Convert.DBNull;
            }
            
            public bool IsIncludeBoundsNull() {
                return this.IsNull(this.tableTestCases_.IncludeBoundsColumn);
            }
            
            public void SetIncludeBoundsNull() {
                this[this.tableTestCases_.IncludeBoundsColumn] = System.Convert.DBNull;
            }
            
            public bool IsResampleIntervalNull() {
                return this.IsNull(this.tableTestCases_.ResampleIntervalColumn);
            }
            
            public void SetResampleIntervalNull() {
                this[this.tableTestCases_.ResampleIntervalColumn] = System.Convert.DBNull;
            }
            
            public bool IsResultIdNull() {
                return this.IsNull(this.tableTestCases_.ResultIdColumn);
            }
            
            public void SetResultIdNull() {
                this[this.tableTestCases_.ResultIdColumn] = System.Convert.DBNull;
            }
            
            public TsCHdaItemValue[] GetItemValues() {
                return ((TsCHdaItemValue[])(this.GetChildRows(this.Table.ChildRelations["TestCase_ItemValue"])));
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TestCaseChangeEvent : EventArgs {
            
            private TestCase eventRow_;
            
            private DataRowAction eventAction_;
            
            public TestCaseChangeEvent(TestCase row, DataRowAction action) {
                this.eventRow_ = row;
                this.eventAction_ = action;
            }
            
            public TestCase Row {
                get {
                    return this.eventRow_;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction_;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ItemValuesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnValue_;
            
            private DataColumn columnQuality_;
            
            private DataColumn columnTimestamp_;
            
            private DataColumn columnTestCaseId_;
            
            internal ItemValuesDataTable() : 
                    base("TsCHdaItemValue") {
                this.InitClass();
            }
            
            internal ItemValuesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ValueColumn {
                get {
                    return this.columnValue_;
                }
            }
            
            internal DataColumn QualityColumn {
                get {
                    return this.columnQuality_;
                }
            }
            
            internal DataColumn TimestampColumn {
                get {
                    return this.columnTimestamp_;
                }
            }
            
            internal DataColumn TestCaseIdColumn {
                get {
                    return this.columnTestCaseId_;
                }
            }
            
            public TsCHdaItemValue this[int index] {
                get {
                    return ((TsCHdaItemValue)(this.Rows[index]));
                }
            }
            
            public event ItemValueChangeEventHandler ItemValueChanged;
            
            public event ItemValueChangeEventHandler ItemValueChanging;
            
            public event ItemValueChangeEventHandler ItemValueDeleted;
            
            public event ItemValueChangeEventHandler ItemValueDeleting;
            
            public void AddItemValue(TsCHdaItemValue row) {
                this.Rows.Add(row);
            }
            
            public TsCHdaItemValue AddItemValue(System.Double value, int quality, System.Decimal timestamp, TestCase parentTestCaseByTestCaseItemValue) {
                TsCHdaItemValue rowItemValue = ((TsCHdaItemValue)(this.NewRow()));
                rowItemValue.ItemArray = new object[] {
                        value,
                        quality,
                        timestamp,
                        parentTestCaseByTestCaseItemValue[8]};
                this.Rows.Add(rowItemValue);
                return rowItemValue;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ItemValuesDataTable cln = ((ItemValuesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ItemValuesDataTable();
            }
            
            internal void InitVars() {
                this.columnValue_ = this.Columns["Value"];
                this.columnQuality_ = this.Columns["Quality"];
                this.columnTimestamp_ = this.Columns["Timestamp"];
                this.columnTestCaseId_ = this.Columns["TestCase_Id"];
            }
            
            private void InitClass() {
                this.columnValue_ = new DataColumn("Value", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValue_);
                this.columnQuality_ = new DataColumn("Quality", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnQuality_);
                this.columnTimestamp_ = new DataColumn("Timestamp", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTimestamp_);
                this.columnTestCaseId_ = new DataColumn("TestCase_Id", typeof(int), null, System.Data.MappingType.Hidden);
                this.Columns.Add(this.columnTestCaseId_);
            }
            
            public TsCHdaItemValue NewItemValue() {
                return ((TsCHdaItemValue)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new TsCHdaItemValue(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(TsCHdaItemValue);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ItemValueChanged != null)) {
                    this.ItemValueChanged(this, new ItemValueChangeEvent(((TsCHdaItemValue)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ItemValueChanging != null)) {
                    this.ItemValueChanging(this, new ItemValueChangeEvent(((TsCHdaItemValue)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ItemValueDeleted != null)) {
                    this.ItemValueDeleted(this, new ItemValueChangeEvent(((TsCHdaItemValue)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ItemValueDeleting != null)) {
                    this.ItemValueDeleting(this, new ItemValueChangeEvent(((TsCHdaItemValue)(e.Row)), e.Action));
                }
            }
            
            public void RemoveItemValue(TsCHdaItemValue row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TsCHdaItemValue : DataRow {
            
            private ItemValuesDataTable tableItemValues_;
            
            internal TsCHdaItemValue(DataRowBuilder rb) : 
                    base(rb) {
                this.tableItemValues_ = ((ItemValuesDataTable)(this.Table));
            }
            
            public System.Double Value {
                get {
                    try {
                        return ((System.Double)(this[this.tableItemValues_.ValueColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableItemValues_.ValueColumn] = value;
                }
            }
            
            public int Quality {
                get {
                    if (this.IsQualityNull()) {
                        return 0;
                    }
                    else {
                        return ((int)(this[this.tableItemValues_.QualityColumn]));
                    }
                }
                set {
                    this[this.tableItemValues_.QualityColumn] = value;
                }
            }
            
            public System.Decimal Timestamp {
                get {
                    if (this.IsTimestampNull()) {
                        return 0m;
                    }
                    else {
                        return ((System.Decimal)(this[this.tableItemValues_.TimestampColumn]));
                    }
                }
                set {
                    this[this.tableItemValues_.TimestampColumn] = value;
                }
            }
            
            public TestCase TestCase {
                get {
                    return ((TestCase)(this.GetParentRow(this.Table.ParentRelations["TestCase_ItemValue"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["TestCase_ItemValue"]);
                }
            }
            
            public bool IsValueNull() {
                return this.IsNull(this.tableItemValues_.ValueColumn);
            }
            
            public void SetValueNull() {
                this[this.tableItemValues_.ValueColumn] = System.Convert.DBNull;
            }
            
            public bool IsQualityNull() {
                return this.IsNull(this.tableItemValues_.QualityColumn);
            }
            
            public void SetQualityNull() {
                this[this.tableItemValues_.QualityColumn] = System.Convert.DBNull;
            }
            
            public bool IsTimestampNull() {
                return this.IsNull(this.tableItemValues_.TimestampColumn);
            }
            
            public void SetTimestampNull() {
                this[this.tableItemValues_.TimestampColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ItemValueChangeEvent : EventArgs {
            
            private TsCHdaItemValue eventRow_;
            
            private DataRowAction eventAction_;
            
            public ItemValueChangeEvent(TsCHdaItemValue row, DataRowAction action) {
                this.eventRow_ = row;
                this.eventAction_ = action;
            }
            
            public TsCHdaItemValue Row {
                get {
                    return this.eventRow_;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction_;
                }
            }
        }
    }
}
