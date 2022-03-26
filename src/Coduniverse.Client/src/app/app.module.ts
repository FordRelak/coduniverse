import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SpaceobjectComponent } from './spaceobject/spaceobject.component';
import { StarSystemService } from './services/starsystem.service';
import { FormComponent } from './form/form.component';
import { StarSystemComponent } from './star-system/star-system.component';

@NgModule({
  declarations: [
    AppComponent,
    SpaceobjectComponent,
    FormComponent,
    StarSystemComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [StarSystemService],
  bootstrap: [AppComponent]
})
export class AppModule { }
