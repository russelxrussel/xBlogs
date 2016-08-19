Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class prereg_report

    Private Sub prereg_report_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.CrystalReportViewer1.ReportSource = Application.StartupPath & "\Reports\prereg_new_report.rpt"
        Call LoadReport()
    End Sub


    Private Sub LoadReport()
        Try

            ' Dim cryRpt As New ReportDocument
            Call reportConn(Application.StartupPath & "\Reports\prereg_new_report.rpt")


            'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            'Dim crParameterFieldDefinition As ParameterFieldDefinition
            'Dim crParameterValues As New ParameterValues
            'Dim crParameterDiscreteValue As New ParameterDiscreteValue

            'crParameterDiscreteValue.Value = _companyCode
            'crParameterFieldDefinitions = rd.DataDefinition.ParameterFields()
            'crParameterFieldDefinition = crParameterFieldDefinitions.Item("companyCode")
            'crParameterValues = crParameterFieldDefinition.CurrentValues

            'crParameterValues.Clear()
            'crParameterValues.Add(crParameterDiscreteValue)
            'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            'Dim crParameterFieldDefinitions2 As ParameterFieldDefinitions
            'Dim crParameterFieldDefinition2 As ParameterFieldDefinition
            'Dim crParameterValues2 As New ParameterValues
            'Dim crParameterDiscreteValue2 As New ParameterDiscreteValue

            'crParameterDiscreteValue2.Value = _XPPCode
            'crParameterFieldDefinitions2 = rd.DataDefinition.ParameterFields()
            'crParameterFieldDefinition2 = crParameterFieldDefinitions2.Item("periodCode")
            'crParameterValues2 = crParameterFieldDefinition2.CurrentValues

            'crParameterValues2.Clear()
            'crParameterValues2.Add(crParameterDiscreteValue2)
            'crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2)


            ''Default Year
            'Dim crParameterFieldDefinitions3 As ParameterFieldDefinitions
            'Dim crParameterFieldDefinition3 As ParameterFieldDefinition
            'Dim crParameterValues3 As New ParameterValues
            'Dim crParameterDiscreteValue3 As New ParameterDiscreteValue

            'crParameterDiscreteValue3.Value = _implementedYear
            'crParameterFieldDefinitions3 = rd.DataDefinition.ParameterFields()
            'crParameterFieldDefinition3 = crParameterFieldDefinitions3.Item("yearSelected")
            'crParameterValues3 = crParameterFieldDefinition3.CurrentValues

            'crParameterValues3.Clear()
            'crParameterValues3.Add(crParameterDiscreteValue3)
            'crParameterFieldDefinition3.ApplyCurrentValues(crParameterValues3)


            'Dim toCompanyName As TextObject

            'toCompanyName = rd.ReportDefinition.Sections("Section3").ReportObjects("txtCompanyName")
            'toCompanyName.Text = _companyName


            'Dim td As TextObject
            'Dim td2 As TextObject

            'Dim toCompanyName As TextObject

            'toCompanyName = rd.ReportDefinition.Sections("Section2").ReportObjects("txtCompanyName")
            'toCompanyName.Text = _companyName

            'td2 = rd.ReportDefinition.Sections("Section2").ReportObjects("txtfullname")
            'td2.Text = _employeeName

            'td = rd.ReportDefinition.Sections("Section5").ReportObjects("txtprintedBy")
            'td.Text = _username




            With CrystalReportViewer1
                .ReportSource = rd
                .Refresh()
            End With
        Catch ex As CrystalReportsException
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class