using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirtableApiClient;

namespace Faculti.Services
{
    internal class AirtableHelper
    {
        #region Secret

        public string API_KEY = "keymjNiDiGUwVrc1l";
        public string BASE_ID = "appozkjZ9cVIYBfRB";

        #endregion Secret

        public async Task<AirtableListRecordsResponse> ListRecords(
           string tableName,
           string offset = null,
           IEnumerable<string> fields = null,
           string filterByFormula = null,
           int? maxRecords = null,
           int? pageSize = null,
           IEnumerable<Sort> sort = null,
           string view = null)
        {
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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
                return response;
            }
        }

        public async Task<AirtableRecord> RetrieveRecord(string tableName, string id)
        {
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
            {
                Task<AirtableRetrieveRecordResponse> task = airtableBase.RetrieveRecord(tableName, id);

                var response = await task;
                return response.Record;
            }
        }

        public async void CreateRecord(string tableName, Fields fields, bool typecast = false)
        {
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
            {
                Task<AirtableDeleteRecordResponse> task = airtableBase.DeleteRecord(tableName, id);
                var response = await task;
            }
        }

        public async void CreateMultipleRecords(string tableName, Fields[] fields, bool typeCast = false)
        {
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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
            using (AirtableBase airtableBase = new AirtableBase(API_KEY, BASE_ID))
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