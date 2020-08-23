<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Main.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- ########## START: MAIN PANEL ########## -->
   
      <div class="pd-30">
        <h4 class="tx-gray-800 mg-b-5">Dashboard</h4>
        <p class="mg-b-0">Visitors</p>
      </div><!-- d-flex -->

      <div class="br-pagebody mg-t-5 pd-x-30">
        <div class="row row-sm">
          <div class="col-sm-6 col-xl-3">
            <div class="bg-teal rounded overflow-hidden">
              <div class="pd-25 d-flex align-items-center">
                <i class="ion ion-earth tx-60 lh-0 tx-white op-7"></i>
                <div class="mg-l-20">
                  <p class="tx-10 tx-spacing-1 tx-mont tx-medium tx-uppercase tx-white-8 mg-b-10">Today's Visitor</p>
                  <p class="tx-24 tx-white tx-lato tx-bold mg-b-2 lh-1">50</p>
                  <span class="tx-11 tx-roboto tx-white-6">24% higher yesterday</span>
                </div>
              </div>
            </div>
          </div><!-- col-3 -->
          <div class="col-sm-6 col-xl-3 mg-t-20 mg-sm-t-0">
            <div class="bg-danger rounded overflow-hidden">
              <div class="pd-25 d-flex align-items-center">
                <i class="ion ion-bag tx-60 lh-0 tx-white op-7"></i>
                <div class="mg-l-20">
                  <p class="tx-10 tx-spacing-1 tx-mont tx-medium tx-uppercase tx-white-8 mg-b-10">Today's Registration</p>
                  <p class="tx-24 tx-white tx-lato tx-bold mg-b-2 lh-1">390</p>
                  <span class="tx-11 tx-roboto tx-white-6">20% Increase Visitors </span>
                </div>
              </div>
            </div>
          </div><!-- col-3 -->
          <div class="col-sm-6 col-xl-3 mg-t-20 mg-xl-t-0">
            <div class="bg-primary rounded overflow-hidden">
              <div class="pd-25 d-flex align-items-center">
                <i class="ion ion-monitor tx-60 lh-0 tx-white op-7"></i>
                <div class="mg-l-20">
                  <p class="tx-10 tx-spacing-1 tx-mont tx-medium tx-uppercase tx-white-8 mg-b-10">% Today's Travel Agent</p>
                  <p class="tx-24 tx-white tx-lato tx-bold mg-b-2 lh-1">54%</p>
                  <span class="tx-11 tx-roboto tx-white-6">10% average Travel Agents</span>
                </div>
              </div>
            </div>
          </div><!-- col-3 -->
          <div class="col-sm-6 col-xl-3 mg-t-20 mg-xl-t-0">
            <div class="bg-br-primary rounded overflow-hidden">
              <div class="pd-25 d-flex align-items-center">
                <i class="ion ion-clock tx-60 lh-0 tx-white op-7"></i>
                <div class="mg-l-20">
                  <p class="tx-10 tx-spacing-1 tx-mont tx-medium tx-uppercase tx-white-8 mg-b-10">Feedback Rate</p>
                  <p class="tx-24 tx-white tx-lato tx-bold mg-b-2 lh-1">32%</p>
                  <span class="tx-11 tx-roboto tx-white-6">65% on average time</span>
                </div>
              </div>
            </div>
          </div><!-- col-3 -->
        </div><!-- row -->

        <div class="row row-sm mg-t-20">
          <div class="col-8">
            <div class="card pd-0 bd-0 shadow-base">
              <div class="pd-x-30 pd-t-30 pd-b-15">
                <div class="d-flex align-items-center justify-content-between">
                  <div>
                    <h6 class="tx-13 tx-uppercase tx-inverse tx-semibold tx-spacing-1">User Performance</h6>
                    <p class="mg-b-0">Overall Good</p>
                  </div>
                  <div class="tx-13">
                    <p class="mg-b-0"><span class="square-8 rounded-circle bg-purple mg-r-10"></span> Traveller Agents</p>
                    <p class="mg-b-0"><span class="square-8 rounded-circle bg-pink mg-r-10"></span>Individual User</p>
                  </div>
                </div><!-- d-flex -->
              </div>
              <div class="pd-x-15 pd-b-15">
                <div id="ch1" class="br-chartist br-chartist-2 ht-200 ht-sm-300"></div>
              </div>
            </div><!-- card -->

            <div class="card bd-0 shadow-base pd-30 mg-t-20">
              <div class="d-flex align-items-center justify-content-between mg-b-30">
                <div>
                  <h6 class="tx-13 tx-uppercase tx-inverse tx-semibold tx-spacing-1">Newly Registered Users</h6>
                  <p class="mg-b-0"><i class="icon ion-calendar mg-r-5"></i> From March 2018 - April 2018</p>
                </div>
                div><!-- d-flex -->

              </div>
            </div><!-- card -->

            <div class="card shadow-base card-body pd-25 bd-0 mg-t-20">
              <div class="row">
                <div class="col-sm-6">
                  <h6 class="card-title tx-uppercase tx-12">Statistics Summary</h6>
                  <p class="display-4 tx-medium tx-inverse mg-b-5 tx-lato">35%</p>
                  <div class="progress mg-b-10">
                    <div class="progress-bar bg-primary progress-bar-xs wd-30p" role="progressbar" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100"></div>
                  </div><!-- progress -->
                  
              </div><!-- row -->
            </div><!-- card -->


          </div><!-- col-9 -->
          

            <div class="card bg-transparent shadow-base bd-0 mg-t-20">
              <div class="bg-primary rounded-top">
                <div class="pd-x-30 pd-t-30">
                  <h6 class="tx-13 tx-uppercase tx-white tx-semibold tx-spacing-1">Booking Status</h6>
                  <p class="mg-b-20 tx-white-6">As of November 17 - 18, 2018</p>
                  <h3 class="tx-lato tx-white mg-b-0">700 <i class="icon ion-android-arrow-up tx-white-5"></i></h3>
                </div>
                <div id="chartLine1" class="wd-100p ht-150"></div>
              </div>
              <div class="bg-white pd-20 rounded-bottom d-flex align-items-center justify-content-between">
                <div class="d-flex align-items-start">
                  
                  <div class="mg-l-15">
                    <label class="tx-uppercase tx-10 tx-medium tx-spacing-1 mg-b-0">Average Bookings</label>
                    <h6 class="tx-inverse mg-b-0 tx-lato tx-bold">101</h6>
                  </div>
                </div><!-- d-flex -->
                <div class="d-flex align-items-center">
                  
                  <div class="mg-l-15">
                    <label class="tx-uppercase tx-10 tx-medium tx-spacing-1 mg-b-0">Total Bookings</label>
                    <h6 class="tx-inverse mg-b-0 tx-lato tx-bold">700</h6>
                  </div>
                </div><!-- d-flex -->
              </div><!-- d-flex -->
            </div><!-- card -->


          </div><!-- col-3 -->
        </div><!-- row -->

      </div><!-- br-pagebody -->
   
   
    <!-- ########## END: MAIN PANEL ########## -->
</asp:Content>

