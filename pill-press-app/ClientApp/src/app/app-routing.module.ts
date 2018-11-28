import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BusinessProfileComponent } from './business-information/business-profile/business-profile.component';
import { HomeComponent } from './home/home.component';
import { PolicyDocumentComponent } from './policy-document/policy-document.component';
//import { ResultComponent } from './result/result.component';
import { SurveyPrimaryComponent } from './survey/primary.component';
import { SurveyTestComponent } from './survey/test.component';
//import { NewsletterConfirmationComponent } from './newsletter-confirmation/newsletter-confirmation.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { CanDeactivateGuard } from './services/can-deactivate-guard.service';
import { BCeidAuthGuard } from './services/bceid-auth-guard.service';
import { DashboardLiteComponent } from './dashboard-lite/dashboard-lite.component';
import { ProfileSummaryComponent } from './business-information/profile-summary/profile-summary.component';
import { WaiverApplicationComponent } from './owner-applications/waiver/waiver-application/waiver-application.component';
import { WaiverReviewComponent } from './owner-applications/waiver/waiver-review/waiver-review.component';
import { ThankYouComponent } from './owner-applications/waiver/thank-you/thank-you.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'business-profile',
    component: BusinessProfileComponent,
    canDeactivate: [CanDeactivateGuard],
    canActivate: [BCeidAuthGuard]
  },
  {
    path: 'business-profile-review',
    component: ProfileSummaryComponent,
    // canDeactivate: [CanDeactivateGuard],
    canActivate: [BCeidAuthGuard]
  },
  {
    path: 'waiver-application/:id',
    component: WaiverApplicationComponent,
    // canDeactivate: [CanDeactivateGuard],
    canActivate: [BCeidAuthGuard]
  },
  {
    path: 'waiver-application-review/:id',
    component: WaiverReviewComponent,
    // canDeactivate: [CanDeactivateGuard],
    canActivate: [BCeidAuthGuard]
  },
  {
    path: 'waiver-thank-you/:id',
    component: ThankYouComponent,
    // canDeactivate: [CanDeactivateGuard],
    canActivate: [BCeidAuthGuard]
  },
  {
    path: 'dashboard',
    component: DashboardLiteComponent,
    // canDeactivate: [CanDeactivateGuard],
    canActivate: [BCeidAuthGuard]
  },
  {
    path: 'policy-document/:slug',
    component: PolicyDocumentComponent
  },
  {
    path: 'prv',
    redirectTo: 'prv/survey'
  },
  {
    path: 'survey-test',
    component: SurveyTestComponent,
    data: {
      breadcrumb: 'Survey Test'
    }
  },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule { }
