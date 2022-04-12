<?php

/**
 * This file has been auto-generated
 * by the Symfony Routing Component.
 */

return [
    true, // $matchHost
    [ // $staticRoutes
        '/_profiler' => [[['_route' => '_profiler_home', '_controller' => 'web_profiler.controller.profiler::homeAction'], null, null, null, true, false, null]],
        '/_profiler/search' => [[['_route' => '_profiler_search', '_controller' => 'web_profiler.controller.profiler::searchAction'], null, null, null, false, false, null]],
        '/_profiler/search_bar' => [[['_route' => '_profiler_search_bar', '_controller' => 'web_profiler.controller.profiler::searchBarAction'], null, null, null, false, false, null]],
        '/_profiler/phpinfo' => [[['_route' => '_profiler_phpinfo', '_controller' => 'web_profiler.controller.profiler::phpinfoAction'], null, null, null, false, false, null]],
        '/_profiler/open' => [[['_route' => '_profiler_open_file', '_controller' => 'web_profiler.controller.profiler::openAction'], null, null, null, false, false, null]],
        '/' => [
            [['_route' => 'home', '_controller' => 'App\\Controller\\AccueilController::home'], null, null, null, false, false, null],
            [['_route' => 'index', '_controller' => 'App\\Controller\\AccueilController::index'], 'localhost', null, null, false, false, null],
        ],
        '/connexionold' => [[['_route' => 'app_connexion', '_controller' => 'App\\Controller\\ConnexionController::connexionForm'], null, null, null, false, false, null]],
        '/incription' => [[['_route' => 'app_inscription', '_controller' => 'App\\Controller\\ConnexionController::inscriptionForm'], null, null, null, false, false, null]],
        '/contact' => [
            [['_route' => 'app_contact', '_controller' => 'App\\Controller\\ContactController::index'], null, null, null, false, false, null],
            [['_route' => 'contact', '_controller' => 'App\\Controller\\ContactController::index'], 'localhost', null, null, false, false, null],
        ],
        '/propos' => [
            [['_route' => 'app_propos', '_controller' => 'App\\Controller\\ProposController::index'], null, null, null, false, false, null],
            [['_route' => 'propos', '_controller' => 'App\\Controller\\ProposController::index'], 'localhost', null, null, false, false, null],
        ],
        '/inscription' => [
            [['_route' => 'security_registration', '_controller' => 'App\\Controller\\SecurityController::registration'], null, null, null, false, false, null],
            [['_route' => 'inscription', '_controller' => 'App\\Controller\\InscriptionController::index'], 'localhost', null, null, false, false, null],
        ],
        '/connexion' => [[['_route' => 'security_login', '_controller' => 'App\\Controller\\SecurityController::login'], null, null, null, false, false, null]],
        '/deconnexion' => [[['_route' => 'security_logout', '_controller' => 'App\\Controller\\SecurityController::logout'], null, null, null, false, false, null]],
        '/traversee' => [[['_route' => 'app_traversee_index', '_controller' => 'App\\Controller\\TraverseeController::index'], null, ['GET' => 0], null, true, false, null]],
        '/traversee/new' => [[['_route' => 'app_traversee_new', '_controller' => 'App\\Controller\\TraverseeController::new'], null, ['GET' => 0, 'POST' => 1], null, false, false, null]],
        '/accueil' => [[['_route' => 'accueil', '_controller' => 'App\\Controller\\AccueilController::index'], 'localhost', null, null, false, false, null]],
        '/login' => [[['_route' => 'connexion', '_controller' => 'App\\Controller\\SecurityController::login'], 'localhost', null, null, false, false, null]],
        '/compte' => [[['_route' => 'compte', '_controller' => 'App\\Controller\\CompteController::index'], 'localhost', null, null, false, false, null]],
    ],
    [ // $regexpList
        0 => '{^(?'
            .'|(?:(?:[^./]*+\\.)++)(?'
                .'|/_(?'
                    .'|error/(\\d+)(?:\\.([^/]++))?(*:60)'
                    .'|wdt/([^/]++)(*:79)'
                    .'|profiler/([^/]++)(?'
                        .'|/(?'
                            .'|search/results(*:124)'
                            .'|router(*:138)'
                            .'|exception(?'
                                .'|(*:158)'
                                .'|\\.css(*:171)'
                            .')'
                        .')'
                        .'|(*:181)'
                    .')'
                .')'
                .'|/traversee/([^/]++)(?'
                    .'|(*:213)'
                    .'|/edit(*:226)'
                    .'|(*:234)'
                .')'
            .')'
            .')/?$}sD',
    ],
    [ // $dynamicRoutes
        60 => [[['_route' => '_preview_error', '_controller' => 'error_controller::preview', '_format' => 'html'], ['code', '_format'], null, null, false, true, null]],
        79 => [[['_route' => '_wdt', '_controller' => 'web_profiler.controller.profiler::toolbarAction'], ['token'], null, null, false, true, null]],
        124 => [[['_route' => '_profiler_search_results', '_controller' => 'web_profiler.controller.profiler::searchResultsAction'], ['token'], null, null, false, false, null]],
        138 => [[['_route' => '_profiler_router', '_controller' => 'web_profiler.controller.router::panelAction'], ['token'], null, null, false, false, null]],
        158 => [[['_route' => '_profiler_exception', '_controller' => 'web_profiler.controller.exception_panel::body'], ['token'], null, null, false, false, null]],
        171 => [[['_route' => '_profiler_exception_css', '_controller' => 'web_profiler.controller.exception_panel::stylesheet'], ['token'], null, null, false, false, null]],
        181 => [[['_route' => '_profiler', '_controller' => 'web_profiler.controller.profiler::panelAction'], ['token'], null, null, false, true, null]],
        213 => [[['_route' => 'app_traversee_show', '_controller' => 'App\\Controller\\TraverseeController::show'], ['id'], ['GET' => 0], null, false, true, null]],
        226 => [[['_route' => 'app_traversee_edit', '_controller' => 'App\\Controller\\TraverseeController::edit'], ['id'], ['GET' => 0, 'POST' => 1], null, false, false, null]],
        234 => [
            [['_route' => 'app_traversee_delete', '_controller' => 'App\\Controller\\TraverseeController::delete'], ['id'], ['POST' => 0], null, false, true, null],
            [null, null, null, null, false, false, 0],
        ],
    ],
    null, // $checkCondition
];
