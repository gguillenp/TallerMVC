# Taller MVC en C# — Proyecto listo (tabla maestra: `curso`)

Este proyecto ya está armado según lo explicado en las dos capacitaciones y
cumple lo pedido en `Taller_MVC_2026.pdf`: tres capas (Vista, Controlador,
Modelo) referenciadas entre sí, un proyecto de biblioteca de clases por capa,
un proyecto de ejecución aparte, conexión ODBC vía DSN, y uso de una tabla
maestra de un proyecto propio (aquí, `curso` del script de asignación de
cursos que me diste).

Lo único que no puedo hacer por ti desde aquí es lo que requiere tu máquina
Windows con Visual Studio y MySQL instalados: crear el DSN, compilar/ejecutar
y grabar el video. Todo el código, los `.csproj` y el `.sln` ya están hechos
y referenciados correctamente, así que solo sigue estos pasos.

## Por qué la tabla `curso`

El script `script_asignaciones_db_completo.sql` trae ~22 tablas. Usé `curso`
porque es una tabla maestra (sin llaves foráneas, catálogo simple: código,
nombre, créditos, etc.) igual de sencilla que el ejemplo `empleados` que usó
el instructor. Si un compañero de equipo ya la está usando, cámbiala en un
solo lugar: la línea `string nombreTabla = "curso";` en
`CapaVista_MVC1/FormPrincipal.cs`. Otras tablas maestras sin dependencias en
el mismo script: `rol`, `permiso`, `facultad`, `edificio`,
`periodo_academico`.

## Estructura del proyecto

```
TallerMVC1/
├── TallerMVC1.sln                     (abre esto en Visual Studio)
├── CapaModelo_MVC1/                   (biblioteca de clases)
│   ├── Conexion.cs                    (abrir/cerrar conexión ODBC)
│   └── Sentencias.cs                  (SELECT * FROM curso)
├── CapaControlador_MVC1/              (biblioteca de clases)
│   └── Controlador.cs                 (llama al modelo, arma el DataTable)
├── CapaVista_MVC1/                    (biblioteca de clases)
│   ├── FormPrincipal.cs
│   ├── FormPrincipal.Designer.cs      (botón "Consultar datos" + DataGridView)
│   └── FormPrincipal.resx
├── EjecucionTallerMVC1/               (aplicación Windows Forms, es la que se ejecuta)
│   └── Program.cs
└── script_asignaciones_db_completo.sql
```

Las referencias entre capas ya están puestas en los `.csproj`:
Vista → Controlador → Modelo (una sola dirección, como pide el patrón).

## Paso 1 — Base de datos

1. Abre MySQL Workbench, conéctate a tu servidor local.
2. Ejecuta el archivo `script_asignaciones_db_completo.sql` completo. Esto
   crea la base `asignacion_cursos` con todas las tablas y datos de ejemplo,
   incluida `curso`.
3. Verifica: `SELECT * FROM asignacion_cursos.curso;` debe devolver 6 filas.

## Paso 2 — Crear el DSN (ODBC)

1. Abre "Orígenes de datos ODBC (64 bits)" en Windows.
2. Pestaña "DSN de usuario" → Agregar → selecciona el driver
   `MySQL ODBC 8.0/9.x Unicode Driver` (el que tengas instalado).
3. Configúralo así:
   - **Data Source Name:** `asignacion_cursos` (tiene que ser exactamente
     este nombre, porque así está escrito en `Conexion.cs`)
   - **Server:** `localhost`
   - **User:** tu usuario de MySQL (no `root`, como recomendó el instructor)
   - **Password:** el de ese usuario
   - **Database:** `asignacion_cursos`
4. Dale "Test" y confirma que dice conexión exitosa.

Si prefieres usar otro nombre de DSN, cámbialo en la constante
`NOMBRE_DSN` de `CapaModelo_MVC1/Conexion.cs`.

## Paso 3 — Abrir el proyecto en Visual Studio 2022

1. Doble clic en `TallerMVC1.sln`.
2. Verás los 4 proyectos ya creados y referenciados: no hace falta crear
   nada, pero revisa cada uno para entender qué contiene (eso es lo que vas
   a explicar en el video).

## Paso 4 — Compilar

1. Menú Compilar → Compilar solución (o `Ctrl+Shift+B`).
2. Debe compilar los 4 proyectos sin errores. Si algo falla la primera vez,
   vuelve a compilar (es normal, como se vio en el video, a veces hace falta
   una segunda pasada para que regenere las DLL referenciadas).

## Paso 5 — Ejecutar

1. Clic derecho sobre `EjecucionTallerMVC1` → "Establecer como proyecto de
   inicio" (Set as Startup Project).
2. `F5` para ejecutar.
3. Se abre el formulario con el botón "Consultar datos" y el DataGridView.
   Al hacer clic en el botón debe mostrarte las 6 filas de `curso`.

## Paso 6 — Git y GitHub

Desde la carpeta `TallerMVC1` (ábrela en una terminal o en Visual Studio):

```bash
git init
git add .
git commit -m "Proyecto inicial Taller MVC"
git branch -M main
git remote add origin <URL_DE_TU_REPO_EN_GITHUB>
git push -u origin main
```

Luego crea las tres ramas que pide el taller (reemplaza `#carnet` por tu
número de carné real):

```bash
git checkout -b Diseño_Capa_Vista_#carnet
git push -u origin Diseño_Capa_Vista_#carnet

git checkout main
git checkout -b Diseño_Capa_Controlador_#carnet
git push -u origin Diseño_Capa_Controlador_#carnet

git checkout main
git checkout -b Diseño_Capa_Modelo_#carnet
git push -u origin Diseño_Capa_Modelo_#carnet
```

Para el entregable "Archivo Git Log":

```bash
git log --all --graph --decorate > git_log_taller.txt
```

## Paso 7 — Video

Según el PDF: grabar con cámara abierta, sin filtros, mostrando:
- El DSN creado (paso 2).
- Las tres ramas en GitHub.
- Los proyectos de biblioteca de clases y el de ejecución.
- Las referencias entre capas (clic derecho → Referencias en cada proyecto).
- El código de cada capa y el diseño del formulario.
- El proyecto en ejecución (consultando la tabla `curso`).

Sube el video a Google Drive o YouTube y prepara los tres entregables que
pide el PDF: link del video, link del repositorio, y el archivo de git log.
Tienes 72 horas después de la publicación del taller para enviarlo.
