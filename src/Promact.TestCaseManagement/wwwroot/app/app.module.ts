﻿import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';

import { MaterialModule, OverlayContainer, FullscreenOverlayContainer } from '@angular/material';
import { AppComponent } from './app.component';
import { appRoutes } from './app.routes';

import { TestCaseModule } from './testcase/testcase.module';
import { DashboardModule } from './dashboard/dashboard.module';
import { ModulesModule } from './modules/modules.module';
import { SidebarComponent, TopNavComponent } from './shared/index';
import { HttpService } from './core/http.service';
import { NotFoundComponent } from './notfound.component';

@NgModule({
    declarations: [
        AppComponent,
        SidebarComponent,
        TopNavComponent,
        NotFoundComponent
    ],
    imports: [
        BrowserModule,
        TestCaseModule,
        DashboardModule,
        ModulesModule,
        HttpModule,
        MaterialModule.forRoot(),
        RouterModule.forRoot(appRoutes)
    ],
    providers: [
        HttpService
    ],
    exports: [
        SidebarComponent,
        TopNavComponent
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }