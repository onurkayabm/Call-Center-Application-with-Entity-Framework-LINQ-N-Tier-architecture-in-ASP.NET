<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CallCenter.WebUI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Call Center</title>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="page-header">Kişiler</h2>
            <!-- Trigger the modal with a button -->

            <asp:Repeater ID="rptMusteriler" runat="server" OnItemCommand="rptMusteriler_ItemCommand">
                <HeaderTemplate>
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>TC</th>
                                <th>İsim</th>
                                <th>Soyisim</th>
                                <th>Doğum Tarihi</th>
                                <th>
                                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#myModal"><i class="glyphicon glyphicon-plus"></i></button>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("MusteriTC") %></td>
                        <td><%# Eval("MusteriAdi") %></td>
                        <td><%# Eval("MusteriSoyadi") %></td>
                        <td><%# DataBinder.Eval(Container.DataItem, "DogumTarihi", "{0:d/M/yyyy}") %></td>
                        <td>
                            <asp:LinkButton CommandArgument='<%# Eval("MusteriID") %>' CommandName="Detay" CssClass="btn btn-success" Text="Kişi Detay" runat="server" />
                            <asp:LinkButton CommandArgument='<%# Eval("MusteriID") %>' CommandName="Sil" CssClass="btn btn-danger" Text="Kişi Sil" runat="server" OnClientClick="return confirm(&quot;Silmek İstiyormusunuz? &quot;)" />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                </table>
                </FooterTemplate>
            </asp:Repeater>

            <!-- Modal -->
            <div id="myModal" class="modal fade" role="dialog">
                <div class="modal-dialog">

                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Yeni Kişi Ekle</h4>
                        </div>

                        <div class="modal-body">
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">Ad</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtAd" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">Soyad</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtSoyad" />
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label">TC</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtTc" />
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label">Doğum Tarihi</label>
                                    <div class="col-sm-9">
                                        <asp:TextBox CssClass="form-control" runat="server" ID="txtDogumTarihi" TextMode="Date" />
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <asp:Button ID="btnKaydet" CssClass="btn btn-primary" Text="Kişi Ekle" runat="server" OnClick="btnKaydet_Click" />
                                <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            </div>
    </form>
</body>
</html>
