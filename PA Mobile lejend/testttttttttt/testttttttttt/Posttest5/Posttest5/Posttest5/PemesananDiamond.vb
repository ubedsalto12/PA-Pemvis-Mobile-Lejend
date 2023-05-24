Imports MySql.Data.MySqlClient

Public Class PemesananDiamond
    Private Sub PemesananDiamond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kosong()
        Call AutomaticNumber()
    End Sub

    Sub Kosong()
        cbkodediamond.Text = ""
        cbpembayaran.Text = ""
        txtkode.Clear()
        txtnama.Clear()
        txtid.Clear()

        txtdiamond.Clear()

        txtharga.Clear()

        txtjumlah.Clear()
        jml.Text = ""
        nama.Text = ""
        id.Text = ""
        diamond.Text = ""
        harga.Text = ""
        pembayaran.Text = ""
        total.Text = ""
        txtkode.Focus()
    End Sub


    Sub AutomaticNumber()
        Call koneksi()
        CMD = New MySqlCommand("Select * from pemesandiamond where kodepembelian in (select max(kodepembelian) from pemesandiamond)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            UrutanKode = "HLN" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 3) + 1
            UrutanKode = "HLN" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        txtkode.Text = UrutanKode
        RD.Close()
    End Sub

    Private Sub btnpesan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesan.Click
        If txtnama.Text = "" Or
           txtid.Text = "" Or
           txtjumlah.Text = "" Or
           cbkodediamond.Text = "" Or
           cbpembayaran.Text = "" Or
           txtdiamond.Text = "" Or
           txtharga.Text = "" Then
            MsgBox("Data Pemesanan belum lengkap")
            txtnama.Focus()
            Exit Sub


        Else
            CMD = New MySqlCommand("Select * From pemesandiamond where kodepembelian ='" & txtkode.Text & "'", CONN)
            RD = CMD.ExecuteReader

            RD.Read()
            If Not RD.HasRows Then
                Dim harga, jumlah, total As Double
                jumlah = Val(Me.txtjumlah.Text)
                harga = Val(Me.txtharga.Text)


                total = jumlah * harga



                'If jumlah >= 3 Then
                '    diskon = total * 0.1
                '    total = total - diskon

                'End If

                Me.total.Text = total
                Me.txttotal.Text = total
                'Me.diskon.Text = diskon
                Me.jml.Text = jumlah
                Me.nama.Text = txtnama.Text
                Me.id.Text = txtid.Text
                Me.diamond.Text = txtdiamond.Text
                Me.harga.Text = txtharga.Text
                Me.pembayaran.Text = cbpembayaran.Text
                Me.harga.Text = Format(harga, "Rp ###,###")
                'Me.diskon.Text = Format(diskon, "Rp ###,###")
                Me.total.Text = Format(total, "Rp ###,###")


                RD.Close()
                Dim Simpan As String = "insert into pemesandiamond (kodepembelian,kodediamond,nama,id,jumlahdiamond,jumlah,harga,pembayaran) values ('" & txtkode.Text & "','" & cbkodediamond.Text & "','" & txtnama.Text & "','" & txtid.Text & "','" & txtdiamond.Text & "','" & txtjumlah.Text & "','" & txttotal.Text & "','" & cbpembayaran.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah",
                               MsgBoxStyle.Information, "Perhatian")

            End If
            RD.Close()
            txtkode.Focus()
        End If
    End Sub





    Private Sub txttelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MsgBox("Data yang dimasukkan harus angka!!!")
        End If
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[1-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus angka!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus huruf!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub cbkodediamond_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkodediamond.SelectedIndexChanged
        CMD = New MySqlCommand("Select * From tb_diamond where kode='" & cbkodediamond.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = True Then
            txtdiamond.Text = RD.Item(1)
            txtharga.Text = RD.Item(2)
        Else
            MsgBox("Kode diamond ini Tidak Terdaftar")
        End If
        RD.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Kosong()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

End Class