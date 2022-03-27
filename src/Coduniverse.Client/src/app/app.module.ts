import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SpaceobjectComponent } from './spaceobject/spaceobject.component';
import { StarSystemService } from './services/starsystem.service';
import { FormComponent } from './form/form.component';
import { StarSystemComponent } from './star-system/star-system.component';
import { SpaceObjectService } from './services/space-object.service';
import { ReactiveFormsModule } from '@angular/forms';
import { UniverseComponent } from './universe/universe.component';

@NgModule({
  declarations: [
    AppComponent,
    SpaceobjectComponent,
    FormComponent,
    StarSystemComponent,
    UniverseComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [StarSystemService, SpaceObjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
