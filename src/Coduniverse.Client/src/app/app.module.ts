import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";
import { Observable } from 'rxjs';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SpaceobjectComponent } from './spaceobject/spaceobject.component';
import { SpaceobjectService } from './services/spaceobject.service';

@NgModule({
  declarations: [
    AppComponent,
    SpaceobjectComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [SpaceobjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
