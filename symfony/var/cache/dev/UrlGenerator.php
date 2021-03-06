<?php

// This file has been auto-generated by the Symfony Routing Component.

return [
    '_preview_error' => [['code', '_format'], ['_controller' => 'error_controller::preview', '_format' => 'html'], ['code' => '\\d+'], [['variable', '.', '[^/]++', '_format'], ['variable', '/', '\\d+', 'code'], ['text', '/_error']], [], []],
    '_wdt' => [['token'], ['_controller' => 'web_profiler.controller.profiler::toolbarAction'], [], [['variable', '/', '[^/]++', 'token'], ['text', '/_wdt']], [], []],
    '_profiler_home' => [[], ['_controller' => 'web_profiler.controller.profiler::homeAction'], [], [['text', '/_profiler/']], [], []],
    '_profiler_search' => [[], ['_controller' => 'web_profiler.controller.profiler::searchAction'], [], [['text', '/_profiler/search']], [], []],
    '_profiler_search_bar' => [[], ['_controller' => 'web_profiler.controller.profiler::searchBarAction'], [], [['text', '/_profiler/search_bar']], [], []],
    '_profiler_phpinfo' => [[], ['_controller' => 'web_profiler.controller.profiler::phpinfoAction'], [], [['text', '/_profiler/phpinfo']], [], []],
    '_profiler_search_results' => [['token'], ['_controller' => 'web_profiler.controller.profiler::searchResultsAction'], [], [['text', '/search/results'], ['variable', '/', '[^/]++', 'token'], ['text', '/_profiler']], [], []],
    '_profiler_open_file' => [[], ['_controller' => 'web_profiler.controller.profiler::openAction'], [], [['text', '/_profiler/open']], [], []],
    '_profiler' => [['token'], ['_controller' => 'web_profiler.controller.profiler::panelAction'], [], [['variable', '/', '[^/]++', 'token'], ['text', '/_profiler']], [], []],
    '_profiler_router' => [['token'], ['_controller' => 'web_profiler.controller.router::panelAction'], [], [['text', '/router'], ['variable', '/', '[^/]++', 'token'], ['text', '/_profiler']], [], []],
    '_profiler_exception' => [['token'], ['_controller' => 'web_profiler.controller.exception_panel::body'], [], [['text', '/exception'], ['variable', '/', '[^/]++', 'token'], ['text', '/_profiler']], [], []],
    '_profiler_exception_css' => [['token'], ['_controller' => 'web_profiler.controller.exception_panel::stylesheet'], [], [['text', '/exception.css'], ['variable', '/', '[^/]++', 'token'], ['text', '/_profiler']], [], []],
    'home' => [[], ['_controller' => 'App\\Controller\\AccueilController::home'], [], [['text', '/']], [], []],
    'app_connexion' => [[], ['_controller' => 'App\\Controller\\ConnexionController::connexionForm'], [], [['text', '/connexionold']], [], []],
    'app_inscription' => [[], ['_controller' => 'App\\Controller\\ConnexionController::inscriptionForm'], [], [['text', '/incription']], [], []],
    'app_contact' => [[], ['_controller' => 'App\\Controller\\ContactController::index'], [], [['text', '/contact']], [], []],
    'app_propos' => [[], ['_controller' => 'App\\Controller\\ProposController::index'], [], [['text', '/propos']], [], []],
    'security_registration' => [[], ['_controller' => 'App\\Controller\\SecurityController::registration'], [], [['text', '/inscription']], [], []],
    'security_login' => [[], ['_controller' => 'App\\Controller\\SecurityController::login'], [], [['text', '/connexion']], [], []],
    'security_logout' => [[], ['_controller' => 'App\\Controller\\SecurityController::logout'], [], [['text', '/deconnexion']], [], []],
    'app_traversee_index' => [[], ['_controller' => 'App\\Controller\\TraverseeController::index'], [], [['text', '/traversee/']], [], []],
    'app_traversee_new' => [[], ['_controller' => 'App\\Controller\\TraverseeController::new'], [], [['text', '/traversee/new']], [], []],
    'app_traversee_show' => [['id'], ['_controller' => 'App\\Controller\\TraverseeController::show'], [], [['variable', '/', '[^/]++', 'id'], ['text', '/traversee']], [], []],
    'app_traversee_edit' => [['id'], ['_controller' => 'App\\Controller\\TraverseeController::edit'], [], [['text', '/edit'], ['variable', '/', '[^/]++', 'id'], ['text', '/traversee']], [], []],
    'app_traversee_delete' => [['id'], ['_controller' => 'App\\Controller\\TraverseeController::delete'], [], [['variable', '/', '[^/]++', 'id'], ['text', '/traversee']], [], []],
    'index' => [[], ['_controller' => 'App\\Controller\\AccueilController::index'], [], [['text', '/']], [['text', 'localhost']], []],
    'accueil' => [[], ['_controller' => 'App\\Controller\\AccueilController::index'], [], [['text', '/accueil']], [['text', 'localhost']], []],
    'connexion' => [[], ['_controller' => 'App\\Controller\\SecurityController::login'], [], [['text', '/login']], [['text', 'localhost']], []],
    'inscription' => [[], ['_controller' => 'App\\Controller\\InscriptionController::index'], [], [['text', '/inscription']], [['text', 'localhost']], []],
    'compte' => [[], ['_controller' => 'App\\Controller\\CompteController::index'], [], [['text', '/compte']], [['text', 'localhost']], []],
    'contact' => [[], ['_controller' => 'App\\Controller\\ContactController::index'], [], [['text', '/contact']], [['text', 'localhost']], []],
    'propos' => [[], ['_controller' => 'App\\Controller\\ProposController::index'], [], [['text', '/propos']], [['text', 'localhost']], []],
];
