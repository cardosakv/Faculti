using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirtableApiClient;

namespace Faculti.Services
{
    internal class AirtableClient
    {
        #region Secret

        public const string API_KEY = "keymjNiDiGUwVrc1l";
        public const string BASE_ID = "appozkjZ9cVIYBfRB";

        #endregion Secret

        private readonly AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID);

        public async Task<AirtableRecord[]> ListRecords(
           string tableName,
           string offset = null,
           IEnumerable<string> fields = null,
           string filterByFormula = null,
           int? maxRecords = null,
           int? pageSize = null,
           IEnumerable<Sort> sort = null,
           string view = null)
        {
            using (airtableBase)
            {
                Task<AirtableListRecordsResponse> task = airtableBase.ListRecords(
                    tableName,
                    offset,
                    fields,
                    filterByFormula,
                    maxRecords,
                    pageSize,
                    sort,
                    view);

                var response = await task;
                return response.Records.ToArray();
            }
        }

        public async Task<AirtableRecord> RetrieveRecord(string tableName, string id)
        {
            using (airtableBase)
            {
                Task<AirtableRetrieveRecordResponse> task = airtableBase.RetrieveRecord(tableName, id);

                var response = await task;
                return response.Record;
            }
        }

        public async void CreateRecord(string tableName, Fields fields, bool typecast = false)
        {
            using (airtableBase)
            {
                Task<AirtableCreateUpdateReplaceRecordResponse> task = airtableBase.CreateRecord(
                    tableName,
                    fields,
                    typecast);

                var response = await task;
            }
        }

        public async void UpdateRecord(string tableName, Fields fields, string id, bool typeCast = false)
        {
            using (airtableBase)
            {
                Task<AirtableCreateUpdateReplaceRecordResponse> task = airtableBase.UpdateRecord(
                    tableName,
                    fields,
                    id,
                    typeCast);

                var response = await task;
            }
        }

        public async void ReplaceRecord(string tableName, Fields fields, string id, bool typeCast = false)
        {
            using (airtableBase)
            {
                Task<AirtableCreateUpdateReplaceRecordResponse> task = airtableBase.ReplaceRecord(
                    tableName,
                    fields,
                    id,
                    typeCast);

                var response = await task;
            }
        }

        public async void DeleteRecord(string tableName, string id)
        {
            using (airtableBase)
            {
                Task<AirtableDeleteRecordResponse> task = airtableBase.DeleteRecord(tableName, id);
                var response = await task;
            }
        }

        public async void CreateMultipleRecords(string tableName, Fields[] fields, bool typeCast = false)
        {
            using (airtableBase)
            {
                Task<AirtableCreateUpdateReplaceMultipleRecordsResponse> task = airtableBase.CreateMultipleRecords(
                    tableName,
                    fields,
                    typeCast);

                var response = await task;
            }
        }

        public async void UpdateMultipleRecords(string tableName, IdFields[] idFields, bool typeCast = false)
        {
            using (airtableBase)
            {
                Task<AirtableCreateUpdateReplaceMultipleRecordsResponse> task = airtableBase.UpdateMultipleRecords(
                    tableName,
                    idFields,
                    typeCast);

                var response = await task;
            }
        }

        public async void ReplaceMultipleRecords(string tableName, IdFields[] idFields, bool typeCast = false)
        {
            using (airtableBase)
            {
                Task<AirtableCreateUpdateReplaceMultipleRecordsResponse> task = airtableBase.ReplaceMultipleRecords(
                    tableName,
                    idFields,
                    typeCast);

                var response = await task;
            }
        }
    }
}