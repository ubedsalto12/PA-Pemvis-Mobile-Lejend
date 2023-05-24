Imports MySql.Data.MySqlClient

Public Class DataPemesanan
    Private Sub DataPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AutomaticNumber()
        Call Kosong()
        Call Tampiltiket()
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
        id.Text = ""
        harga.Text = ""
        pembayaran.Text = ""
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


    Sub Tampiltiket()
        QUERY = "select * from pemesandiamond"
        DA = New MySqlDataAdapter(QUERY, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data")

        DataGridView1.DataSource = DS.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
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

                Me.total.Text = total
                Me.txttotal.Text = total
                Me.jml.Text = jumlah
                Me.nama.Text = txtnama.Text
                Me.id.Text = txtid.Text
                Me.harga.Text = txtharga.Text
                Me.pembayaran.Text = cbpembayaran.Text
                Me.harga.Text = Format(harga, "Rp ###,###")
                Me.total.Text = Format(total, "Rp ###,###")


                RD.Close()
                Dim Simpan As String = "insert into pemesandiamond (kodepembelian,nama,id,kodediamond,jumlahdiamond,jumlah,harga,pembayaran) values ('" & txtkode.Text & "','" & txtnama.Text & "','" & cbkodediamond.Text & "','" & txtid.Text & "','" & txtdiamond.Text & "','" & txtjumlah.Text & "','" & txttotal.Text & "','" & cbpembayaran.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah",
                               MsgBoxStyle.Information, "Perhatian")
                Tampiltiket()
            End If
            RD.Close()
            txtkode.Focus()
        End If
    End Sub


    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
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
            Dim harga, jumlah, total As Double
            jumlah = Val(Me.txtjumlah.Text)
            harga = Val(Me.txtharga.Text)


            total = jumlah * harga

            Me.total.Text = total
            Me.txttotal.Text = total
            Me.jml.Text = jumlah
            Me.nama.Text = txtnama.Text
            Me.id.Text = txtid.Text
            Me.id.Text = txtdiamond.Text
            Me.harga.Text = txtharga.Text
            Me.pembayaran.Text = cbpembayaran.Text
            Me.harga.Text = Format(harga, "Rp ###,###")
            Me.total.Text = Format(total, "Rp ###,###")



            CMD = New MySqlCommand
            CMD.Connection = CONN
            QUERY = "UPDATE pemesandiamond SET kodepembelian='" & txtkode.Text & "', kodediamond = '" & cbkodediamond.Text & "', nama = '" & txtnama.Text & "', id = '" & txtid.Text & "',  jumlah = '" & txtjumlah.Text & "', jumlahdiamond = '" & txtdiamond.Text & "', jumlah = '" & txtjumlah.Text & "', harga = '" & txttotal.Text & "', pembayaran = '" & cbpembayaran.Text & "' WHERE kodepembelian = '" & txtkode.Text & "'"
            CMD.CommandText = QUERY
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil diubah", vbInformation, "Pemberitahuan")
            Tampiltiket()
            RD.Close()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Kosong()
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkode.Text = "" Then
            MsgBox("Kode pembelian belum diisi")
            txtkode.Focus()
        ElseIf MessageBox.Show("Yakin akan menghapus Data " & txtkode.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CMD = New MySqlCommand("Delete From pemesandiamond Where kodepembelian = '" & txtkode.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            Call Kosong()
            Tampiltiket()

        Else
            Call Kosong()
        End If
    End Sub




    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From pemesandiamond where nama like '%" & txtcari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From pemesandiamond where nama like '%" & txtcari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtkode.Text = DataGridView1.Item(0, i).Value
        txtnama.Text = DataGridView1.Item(1, i).Value
        txtid.Text = DataGridView1.Item(2, i).Value
        cbkodediamond.Text = DataGridView1.Item(3, i).Value
        txtdiamond.Text = DataGridView1.Item(4, i).Value
        txtjumlah.Text = DataGridView1.Item(5, i).Value
        txtharga.Text = DataGridView1.Item(6, i).Value
        cbpembayaran.Text = DataGridView1.Item(7, i).Value


    End Sub


End Class