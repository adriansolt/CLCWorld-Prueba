import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TelephoneListComponent } from './telephone-list/telephone-list.component';
import { TelephoneDetailsComponent } from './telephone-details/telephone-details.component';

@NgModule({
  declarations: [
    AppComponent,
    TelephoneListComponent,
    TelephoneDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
