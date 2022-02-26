// js
function downloadFile(url) {
            const link = document.createElement('a');
            link.href = url;
            link.download = 'file.pdf';
            link.dispatchEvent(new MouseEvent('click'));
        }

// c#
public FileContentResult FilloutTaaWordDocument(int id)
        {
            // Retrieve template
            MemoryStream memStream = new MemoryStream();
            blockBlob.DownloadToStream(memStream);

            memStream.Flush();
            memStream.Position = 0;

            // Fill out data
            using (WordprocessingDocument doc = WordprocessingDocument.Open(templateStream, true))
            {
                // Find the first table in the document.
                DocumentFormat.OpenXml.Wordprocessing.Table table = doc.MainDocumentPart.Document.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().First();

                // Find the first row in the table.
                DocumentFormat.OpenXml.Wordprocessing.TableRow row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().First();


                // Fill in name (last first mi)
                DocumentFormat.OpenXml.Wordprocessing.TableCell cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(1);
                // Find the second paragraph in the cell.
                Paragraph p = cell.Elements<Paragraph>().ElementAt(1);
                // Create the first run in the paragraph.
                Run r = new Run();
                p.InsertAt(r, 0);
                // Create the first text in the run.
                Text t = new Text(ename);
                r.InsertAt(t, 0);

                // Fill in RCC
                row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(1);
                cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(0);
                p = cell.Elements<Paragraph>().ElementAt(1);
                r = new Run();
                p.InsertAt(r, 0);
                t = new Text(rcc);
                r.InsertAt(t, 0);

                // Fill in Supervisor D Number
                row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(2);
                cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(0);
                p = cell.Elements<Paragraph>().ElementAt(1);
                r = new Run();
                p.InsertAt(r, 0);
                t = new Text(dnum);
                r.InsertAt(t, 0);

                // Fill in Supervisor name
                row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(3);
                cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(0);
                p = cell.Elements<Paragraph>().ElementAt(1);
                r = new Run();
                p.InsertAt(r, 0);
                t = new Text(sname);
                r.InsertAt(t, 0);

                // Fill in Supervisor office number if any
                row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(3);
                cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(1);
                p = cell.Elements<Paragraph>().ElementAt(1);
                r = new Run();
                p.InsertAt(r, 0);
                t = new Text(phone);
                r.InsertAt(t, 0);

                // Fill in Supervisor office number if any
                row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(4);
                cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(0);
                p = cell.Elements<Paragraph>().ElementAt(1);
                r = new Run();
                p.InsertAt(r, 0);
                t = new Text(skill);
                r.InsertAt(t, 0);

                // Fill in type (Direct/Indirect)
                row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(4);
                cell = row.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ElementAt(1);
                p = cell.Elements<Paragraph>().ElementAt(1);
                r = new Run();
                p.InsertAt(r, 0);
                t = new Text(laborType);
                r.InsertAt(t, 0);

                // save change
                doc.Save();
            }

            // download
            templateStream.Seek(0, SeekOrigin.Begin);
            Response.AddHeader("Content-Disposition", "inline; filename=" + sFileName);
            return new FileContentResult(templateStream.ToArray(), "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }